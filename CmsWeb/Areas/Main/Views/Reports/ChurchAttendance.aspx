﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Reports.Master" Inherits="System.Web.Mvc.ViewPage<CmsWeb.Areas.Main.Models.Report.ChurchAttendanceModel>" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        body
        {
            font-size: 110%;
        }
        .totalrow td
        {
            border-top: 2px solid black;
            font-weight: bold;
            text-align: right;
        }
        .headerrow th
        {
            border-bottom: 2px solid black;
            text-align: center;
        }
        input#SundayDate
        {
            width: 100px;
            font-size: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        $(function() {
            $(".datepicker").datepicker({
                dateFormat: 'm/d/yy',
                changeMonth: true,
                changeYear: true
            });
            $(".datepicker").change(function() {
                window.location = "/Reports/ChurchAttendance/" + this.value.replace(/\//ig, "-");
            });
        });
    </script>
    <div style="text-align: center">
        <h1>
           Week at a Glance Attendance Report</h1>
        Sunday Date:
        <%=Html.DatePicker("Sunday") %>
        <hr />
        <% foreach (var p in Model.FetchInfo())
           { %>
        <div>
        <table align="center" cellpadding="2">
        <thead>
           <tr>
               <th colspan="<%=p.Cols.Count+4 %>"><%=p.Name %></th>
           </tr>
           <tr>
                <th colspan=<%=p.Cols.Count+2 %>"></th>
                <th colspan="2">Guests</th>
           </tr>
           <tr class="headerrow">
               <td></td>
                   <% foreach (var c in p.Cols)
                      { %>
               <th><%="{0:h:mm tt}".Fmt(c) %></th>
                   <% } %>
               <th>Total</th>
               <th>Local</th>
               <th>Non</th>
           </tr>
        </thead>
                <% foreach (var d in p.Divs)
                   { %>
           <tr>
           <td align="left"><%=d.Name%></td>
               <% foreach (var c in p.Cols)
                  { %>
           <td align="right"><%=d.Meetings.Where(m => m.date.TimeOfDay == c.TimeOfDay).Sum(m => m.Present).ToString("n0") %></td>
               <% } %>
           <td align="right"><a href='/Reports/AttendanceDetail?dt1=<%=d.Dt1.ToString("M/d/yy H:mm") %>&dt2=<%=d.Dt2.ToString("M/d/yy H:mm") %>&divid=<%=d.DivId %>'><%=d.Meetings.Sum(m => m.Present).ToString("n0")%></a></td>
           <td align="right"><%=d.Meetings.Sum(m => m.Visitors).ToString("n0")%></td>
           <td align="right"><%=d.Meetings.Sum(m => m.OutTowners).ToString("n0")%></td>
           </tr>
                <% } %>
           <tr class="totalrow">
           <td align="left">Total</td>
               <% foreach (var c in p.Cols)
                  { %>
           <td><%=p.Divs.Sum(d => d.Meetings.Where(m => m.date.TimeOfDay == c.TimeOfDay).Sum(m => m.Present)).ToString("n0") %></td>
               <% } %>
           <td><%=p.Divs.Sum(d => d.Meetings.Sum(m => m.Present)).ToString("n0")%></td>
           <td><%=p.Divs.Sum(d => d.Meetings.Sum(m => m.Visitors)).ToString("n0")%></td>
           <td><%=p.Divs.Sum(d => d.Meetings.Sum(m => m.OutTowners)).ToString("n0")%></td>
           </tr>
        </table>
        </div>
        <div>&nbsp;</div>
        <% } %>
    </div>
</asp:Content>
