using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using UtilityExtensions;
using CmsData;

namespace CmsWeb.Models
{
    public class StatusFlagsExportModel
    {
        public static EpplusResult StatisFlagsList(Guid qid, string flags)
        {
            var collist = from ss in DbUtil.Db.ViewStatusFlagNamesRoles.ToList()
                          where ss.Role == null || HttpContext.Current.User.IsInRole(ss.Role)
                          select ss;

            string cols = null;
            IEnumerable<string> q = null;

            if (flags.HasValue())
                cols = string.Join(",\n", from f in flags.Split(',')
                                          join c in collist on f equals c.Flag
                                          select "\tss.{0} as [{0}_{1}]".Fmt(c.Flag, c.Name));
            else
                cols = string.Join(",\n", from c in collist
                                          where c.Role == null || HttpContext.Current.User.IsInRole(c.Role)
                                          select "\tss.{0} as [{1}]".Fmt(c.Flag, c.Name));

            var tag = DbUtil.Db.PopulateSpecialTag(qid, DbUtil.TagTypeId_StatusFlags);
            var cn = new SqlConnection(Util.ConnectionString);
            cn.Open();
            var cmd = new SqlCommand(@"
SELECT 
    md.PeopleId, 
	md.[First],
	md.[Last],
	md.Age,
	md.Marital,
	md.Decision,
	md.DecisionDt,
    md.JoinDt,
	md.Baptism,
" + cols + @"
FROM StatusFlagColumns ss
JOIN MemberData md ON md.PeopleId = ss.PeopleId
JOIN dbo.TagPerson tp ON tp.PeopleId = md.PeopleId
WHERE tp.Id = @p1", cn);
            cmd.Parameters.AddWithValue("@p1", tag.Id);
            var rd = cmd.ExecuteReader();


            var ep = new ExcelPackage();
            var ws = ep.Workbook.Worksheets.Add("Sheet1");

            var dt = new DataTable();
            dt.Load(rd);
            ws.Cells["A1"].LoadFromDataTable(dt, true);
            var count = dt.Rows.Count;
            var range = ws.Cells[1, 1, count + 1, dt.Columns.Count];
            var table = ws.Tables.Add(range, "Members");
            table.ShowFilter = false;
            for (var i = 0; i < dt.Columns.Count; i++)
            {
                var col = i + 1;
                var name = dt.Columns[i].ColumnName;
                table.Columns[i].Name = name;
                var colrange = ws.Cells[1, col, count + 2, col];

                if (name.Contains("Date") || name.EndsWith("Dt"))
                {
                    colrange.Style.Numberformat.Format = "mm-dd-yy";
                    colrange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                    ws.Column(col).Width = 12;
                }
            }
            ws.Cells[ws.Dimension.Address].AutoFitColumns();
            return new EpplusResult(ep, "StatusFlags.xlsx");
        }
    }
}