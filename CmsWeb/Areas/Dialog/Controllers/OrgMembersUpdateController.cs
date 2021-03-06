using System;
using System.Web.Mvc;
using CmsWeb.Areas.Dialog.Models;
using CmsData;

namespace CmsWeb.Areas.Dialog.Controllers
{
    // todo: use bootstrap
    [RouteArea("Dialog", AreaPrefix = "OrgMembersUpdate"), Route("{action}")]
    public class OrgMembersUpdateController : CmsStaffController
    {
        [Route("~/OrgMembersUpdate/{oid:int}")]
        public ActionResult Index(int oid)
        {
            if (oid != DbUtil.Db.CurrentOrgId0)
                throw new Exception($"Current org has changed from {oid} to {DbUtil.Db.CurrentOrgId0}, aborting");
            var m = new OrgMembersUpdate { Id = oid };
            return View(m);
        }
        [HttpPost, Route("Update")]
        public ActionResult Update(OrgMembersUpdate m)
        {
            m.Update();
            return View("Updated", m);
        }
        [HttpPost, Route("SmallGroups")]
        public ActionResult SmallGroups(OrgMembersUpdate m)
        {
            return View(m);
        }
        [HttpPost, Route("AddSmallGroup/{sgid:int}")]
        public ActionResult AddSmallGroup(int sgid, OrgMembersUpdate m)
        {
            ViewBag.numberadded = m.AddSmallGroup(sgid);
            return View("SmallGroups", m);
        }
        [HttpPost, Route("RemoveSmallGroup/{sgid:int}")]
        public ActionResult RemoveSmallGroup(int sgid, OrgMembersUpdate m)
        {
            m.RemoveSmallGroup(sgid);
            return View("SmallGroups", m);
        }
        [HttpPost, Route("AddNewSmallGroup")]
        public ActionResult AddNewSmallGroup(OrgMembersUpdate m)
        {
            m.AddNewSmallGroup();
            ModelState.Clear();
            return View("SmallGroups", m);
        }
        [HttpPost, Route("AddTransaction")]
        public ActionResult AddTransaction(OrgMembersUpdate m)
        {
            return View(m);
        }
        [HttpPost, Route("AddFeeAdjustment")]
        public ActionResult AddFeeAdjustment(OrgMembersUpdate m)
        {
            m.AdjustFee = true;
            return View(m);
        }
        [HttpPost, Route("PostTransactions")]
        public ActionResult PostTransactions(OrgMembersUpdate m)
        {
            if (!ModelState.IsValid)
                return View("AddTransaction", m);
            m.PostTransactions();
            return View("AddTransactionDone", m);
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            if (filterContext.ExceptionHandled)
                return;
            filterContext.Result = Message2(filterContext.Exception.Message);
            filterContext.ExceptionHandled = true;
        }
    }
}
