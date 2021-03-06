using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CmsData;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using UtilityExtensions;
using CmsWeb.Models;
using CmsData.Codes;
using CmsWeb.Areas.Finance.Models.BatchImport;

namespace CmsWeb.Areas.Finance.Controllers
{
    [Authorize(Roles = "Finance")]
    [ValidateInput(false)]
    [RouteArea("Finance", AreaPrefix = "PostBundle"), Route("{action}/{id?}")]
    public class PostBundleController : CmsStaffController
    {
        [Route("~/PostBundle/{id:int}")]
        public ActionResult Index(int id)
        {
            var m = new PostBundleModel(id);
            if (m.bundle == null)
                return Content("no bundle " + m.id);
            if (m.bundle.BundleStatusId == BundleStatusCode.Closed)
                return Content("bundle closed");
            m.fund = m.bundle.FundId ?? 1;
            return View(m);
        }

        [HttpPost]
        public ActionResult GetNamePid(PostBundleModel m)
        {
            var o = m.GetNamePidFromId();
            return Json(o);
        }

        [HttpPost]
        public ActionResult PostRow(PostBundleModel m)
        {
            return Json(m.PostContribution(this));
        }

        [HttpPost]
        public ActionResult UpdateRow(PostBundleModel m)
        {
            return Json(m.UpdateContribution(this));
        }

        [HttpPost]
        public ActionResult DeleteRow(PostBundleModel m)
        {
            return Json(m.DeleteContribution());
        }

        [HttpPost]
        public ActionResult Move(int id, int? moveto)
        {
            var b = (from h in DbUtil.Db.BundleHeaders
                     where h.BundleStatusId == BundleStatusCode.Open
                     where h.BundleHeaderId == moveto
                     select h).SingleOrDefault();
            if (b == null)
                return Content("cannot find bundle, or not open");
            var bd = DbUtil.Db.BundleDetails.Single(dd => dd.ContributionId == id);
            var pbid = bd.BundleHeaderId;
            bd.BundleHeaderId = b.BundleHeaderId;
            DbUtil.Db.SubmitChanges();
            var q = (from d in DbUtil.Db.BundleDetails
                     where d.BundleHeaderId == pbid
                     group d by d.BundleHeaderId into g
                     select new
                     {
                         totalitems = g.Sum(d => d.Contribution.ContributionAmount),
                         itemcount = g.Count(),
                     }).Single();

            var sh = (from h in DbUtil.Db.BundleHeaders
                      where h.BundleHeaderId == pbid
                      select h).Single();

            var totalitems = q.totalitems.GetValueOrDefault().ToString("C2");
            var diff = ((sh.TotalCash.GetValueOrDefault() + sh.TotalChecks.GetValueOrDefault() + sh.TotalEnvelopes.GetValueOrDefault()) - q.totalitems.GetValueOrDefault());
            var difference = diff.ToString("C2");

            return Json(new { status = "ok", totalitems, diff, difference, q.itemcount });
        }

        public ActionResult Names(string term)
        {
            var n = PostBundleModel.Names(term, 10).ToArray();
            return Json(n, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Names2(string term)
        {
            var n = PostBundleModel.Names2(term, 30).ToArray();
            return Json(n, JsonRequestBehavior.AllowGet);
        }

        public ActionResult FundTotals(int id)
        {
            var m = new PostBundleModel(id);
            return View(m);
        }

        [HttpGet]
        public ActionResult Batch()
        {
            var dt = Util.Now.Date;
            dt = Util.Now.Date.AddDays(-(int)dt.DayOfWeek);
            ViewData["date"] = dt;
            return View();
        }

        [HttpPost]
        public ActionResult BatchUpload(DateTime date, HttpPostedFileBase file, int? fundid, string text)
        {
            var fromFile = false;
            string s;

            if (file != null)
            {
                var buffer = new byte[file.ContentLength];
                file.InputStream.Read(buffer, 0, file.ContentLength);
                System.Text.Encoding enc;
                if (buffer[0] == 0xFF && buffer[1] == 0xFE)
                {
                    enc = new System.Text.UnicodeEncoding();
                    s = enc.GetString(buffer, 2, buffer.Length - 2);
                }
                else
                {
                    enc = new System.Text.ASCIIEncoding();
                    s = enc.GetString(buffer);
                }

                fromFile = true;
            }
            else
                s = text;

            try
            {
                var id = BatchImportContributions.BatchProcess(s, date, fundid, fromFile);
                if (id.HasValue)
                    return Redirect("/PostBundle/" + id);
                return RedirectToAction("Batch");
            }
            catch (Exception ex)
            {
                return PageMessage(ViewExtensions2.Markdown(ex.Message).ToString());
            }
        }

        public JsonResult Funds()
        {
            var q = from f in DbUtil.Db.ContributionFunds
                    where f.FundStatusId == 1
                    orderby f.FundId
                    select new
                    {
                        value = f.FundId,
                        text = $"{f.FundId} - {f.FundName}",
                    };

            return Json(q.ToList(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Edit(string id, string value)
        {
            var iid = id.Substring(1).ToInt();
            var c = DbUtil.Db.Contributions.SingleOrDefault(co => co.ContributionId == iid);
            if (c != null)
            {
                var m = new PostBundleModel();
                switch (id.Substring(0, 1))
                {
                    case "a":
                        c.ContributionAmount = value.ToDecimal();
                        DbUtil.Db.SubmitChanges();
                        return Json(m.ContributionRowData(this, iid));
                    case "f":
                        c.FundId = value.ToInt();
                        DbUtil.Db.SubmitChanges();
                        return Content($"{c.ContributionFund.FundId} - {c.ContributionFund.FundName}");
                    case "k":
                        c.CheckNo = value;
                        DbUtil.Db.SubmitChanges();
                        return Json(m.ContributionRowData(this, iid));
                }
            }
            return new EmptyResult();
        }

        public ActionResult BankAccountAssociations()
        {
            var q = from c in DbUtil.Db.CardIdentifiers
                    orderby c.Person.Name2
                    select new
                    {
                        c.Person.PeopleId,
                        Name = c.Person.Name2,
                        ac = Util.Decrypt(c.Id)
                    };
            var count = q.Count();
            var ep = new ExcelPackage();
            var ws = ep.Workbook.Worksheets.Add("Sheet1");
            ws.SetExcelHeader("PeopleId", "Name", "Routing/Account Number");
            var colrange = ws.Cells[1, 1, count + 1, 1];
            colrange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            ws.Cells["A2"].LoadFromCollection(q);
            ws.Cells[ws.Dimension.Address].AutoFitColumns();
            return new EpplusResult(ep, "BankAccountAssociations.xlsx");
        }
    }
}
