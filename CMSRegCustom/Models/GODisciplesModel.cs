﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Web;
using CmsData;
using System.Web.Mvc;
using System.Text;
using System.Configuration;
using UtilityExtensions;
using System.Net.Mail;
using System.Web.Security;
using CMSWebCommon.Models;

namespace CMSRegCustom.Models
{
    public class GODisciplesModel
    {
        public string action { get; set; }
        internal int? campus;

        public GODisciplesModel(string action)
        {
            this.action = action;
        }
        public GODisciplesModel(string action, int id)
            : this(action)
        {
            neworg = DbUtil.Db.Organizations.SingleOrDefault(o => o.OrganizationId == id);
            if (neworg != null)
                campus = neworg.CampusId;
        }
        public int neworgid { get { return neworg.OrganizationId; } }
        public int? peopleid { get; set; }
        private Person _person;
        public Person person
        {
            get
            {
                if (_person == null)
                    _person = DbUtil.Db.People.SingleOrDefault(p => p.PeopleId == peopleid);
                return _person;
            }
        }
        public string first { get; set; }
        public string last { get; set; }
        public string dob { get; set; }
        public int? gender { get; set; }
        public int? married { get; set; }
        private DateTime _Birthday;
        private DateTime birthday
        {
            get
            {
                if (_Birthday == DateTime.MinValue)
                    Util.DateValid(dob, out _Birthday);
                return _Birthday;
            }
        }
        public string phone { get; set; }
        public string homecell { get; set; }
        public string email { get; set; }
        public bool preferredemail { get; set; }

        public bool shownew { get; set; }
        public string addr { get; set; }
        public string zip { get; set; }
        public string city { get; set; }
        public string state { get; set; }

        private DiscData.User discuser;
        private Organization neworg;
        private Organization leaderorg;
        private DiscData.Group discorg;
        public string GroupDescription
        {
            get
            {
                if (neworg == null)
                    return "GO Disciples Leaders";
                else
                    return "GO Disciples, " + neworg.OrganizationName;
            }
        }
        public string MemberSignupUrl
        {
            get
            {
                var r = HttpContext.Current.Request;
                return "{0}://{1}/GODisciples/Disciple/{2}".Fmt(
                    r.Url.Scheme, r.Url.Authority, neworg.OrganizationId);
            }
        }
        public string CmsOrgPageUrl
        {
            get
            {
                var r = HttpContext.Current.Request;
                return "{0}://{1}/Organization.aspx?id={2}".Fmt(
                    r.Url.Scheme, r.Url.Authority, neworg.OrganizationId);
            }
        }

        public int FindMember()
        {
            int count;
            _person = SearchPeopleModel.FindPerson(phone, first, last, birthday, out count);
            if (count == 1)
                peopleid = _person.PeopleId;
            return count;
        }

        public void ValidateModel(ModelStateDictionary modelState)
        {
            SearchPeopleModel.ValidateFindPerson(modelState, first, last, birthday, phone);

            if (!phone.HasValue())
                modelState.AddModelError("phone", "phone required");
            if (!email.HasValue() || !Util.ValidEmail(email))
                modelState.AddModelError("email", "Please specify a valid email address.");
            if (shownew)
            {
                if (!gender.HasValue)
                    modelState.AddModelError("gender", "gender required");
                if (!married.HasValue)
                    modelState.AddModelError("married", "marital status required");
                if (!addr.HasValue())
                    modelState.AddModelError("addr", "need address");
                if (zip.GetDigits().Length != 5)
                    modelState.AddModelError("zip", "need 5 digit zip");
                if (!city.HasValue())
                    modelState.AddModelError("city", "need city");
                if (!state.HasValue())
                    modelState.AddModelError("state", "need state");
            }
            if (modelState.IsValid)
            {
                var count = FindMember();
                if (count > 1)
                    modelState.AddModelError("find", "More than one match, sorry");
                else if (count == 0)
                    if (!shownew)
                    {
                        modelState.AddModelError("find", "Cannot find church record.");
                        shownew = true;
                    }
                    else
                        AddPerson();
            }
        }
        private void AddPerson()
        {
            var f = new Family
            {
                AddressLineOne = addr,
                CityName = city,
                StateCode = state,
                ZipCode = zip,
            };
            var p = Person.Add(f, 30,
                null, first.Trim(), null, last.Trim(), dob, married.Value == 20, gender.Value,
                    DbUtil.Settings("GODisciplesOrigin", "70").ToInt(),
                    DbUtil.Settings("GODisciplesEntry", "15").ToInt());
            p.EmailAddress = email;
            p.CampusId = campus;
            if (p.Age >= 18)
                p.PositionInFamilyId = (int)Family.PositionInFamily.PrimaryAdult;
            switch (homecell)
            {
                case "h":
                    f.HomePhone = phone.GetDigits();
                    break;
                case "c":
                    p.CellPhone = phone.GetDigits();
                    break;
            }
            DbUtil.Db.SubmitChanges();
            peopleid = p.PeopleId;
        }
        internal void PerformLeaderSetup()
        {
            MakeUserOnCms();
            MakeDiscUser();
            if (!person.EmailAddress.HasValue())
                person.EmailAddress = email;

            var groupname = "{0} {1} Group".Fmt(
                person.PreferredName,
                person.LastName);
            var g = DiscData.Group.LoadByName(groupname);
            const string STR_GODisciplesLeaders = "GO Disciples Leaders";
            if (!DiscData.Group.IsUserAdmin(discuser, groupname))
            {
                // make a group on disciples with a unique name
                var startname = groupname;
                var i = 1;
                while (DiscData.Group.LoadByName(groupname) != null
                    || DbUtil.Db.Organizations.SingleOrDefault(o => o.OrganizationName == groupname) != null)
                    groupname = startname + " " + i++;
                DiscData.Group.InsertWithRolesOnSubmit(groupname);
                DiscData.DbUtil.Db.SubmitChanges();
                g = DiscData.Group.LoadByName(groupname);

                // add Welcome Text
                var cw = DbUtil.Content("GODisciplesGroupWelcome");
                if (cw != null)
                {
                    g.WelcomeText.Title = cw.Title.Replace("{name}", groupname);
                    g.WelcomeText.Body = cw.Body.Replace("{leader}", person.Name);
                }
                discuser.ForceLogin = true;
                DiscData.DbUtil.Db.SubmitChanges();

                // make a blog on disciples
                var b = new DiscData.Blog();
                b.Title = groupname + " Blog";
                b.OwnerId = discuser.UserId;
                b.Name = b.Title.Replace(" ", "");
                b.Description = DbUtil.Settings("GODisciplesBlogDescription", "A Small Group Discussion");
                b.GroupId = g.Id;
                b.PrivacyLevel = 1;
                DiscData.DbUtil.Db.Blogs.InsertOnSubmit(b);
                DiscData.DbUtil.Db.SubmitChanges();

                // make a new first post on blog
                var firstpost = DbUtil.Content("GODisciplesFirstPost");
                var p = b.NewPost(firstpost.Title, firstpost.Body, discuser.Username, DateTime.Now);
                var cat = DiscData.DbUtil.Db.Categories.Single(ca => ca.Name == "Discipleship");
                var bc = new DiscData.BlogCategoryXref { CatId = cat.Id };
                p.BlogCategoryXrefs.Add(bc);
                DiscData.DbUtil.Db.SubmitChanges();

                // create a new cms org
                leaderorg = DbUtil.Db.Organizations.SingleOrDefault(o =>
                    o.OrganizationId == DbUtil.Settings("GODisciplesLeadersOrgId", "0").ToInt());
                if (leaderorg == null)
                {
                    var div = DbUtil.Db.Divisions.SingleOrDefault(d => d.Name == "GODisciples");
                    if (div == null)
                    {
                        div = new Division { Name = "GO Disciples" };
                        DbUtil.Db.Divisions.InsertOnSubmit(div);
                        DbUtil.Db.SubmitChanges();
                    }
                    leaderorg = new Organization
                    {
                        AttendTrkLevelId = (int)Organization.AttendTrackLevelCode.Individual,
                        OrganizationStatusId = (int)Organization.OrgStatusCode.Active,
                        CreatedDate = DateTime.Now,
                        CreatedBy = Util.UserId1,
                        OrganizationName = STR_GODisciplesLeaders,
                        SecurityTypeId = 0,
                        AttendClassificationId = (int)Organization.AttendanceClassificationCode.Normal,
                        CampusId = DbUtil.Settings("DefaultCampusId", "").ToInt2(),
                        AllowAttendOverlap = false,
                    };
                    leaderorg.DivisionId = div.Id;
                    leaderorg.DivOrgs.Add(new DivOrg { DivId = div.Id });
                    DbUtil.Db.Organizations.InsertOnSubmit(leaderorg);
                    DbUtil.Db.SubmitChanges();
                }
                neworg = leaderorg.CloneOrg();
                neworg.CampusId = campus;
                neworg.OrganizationName = groupname;
                DbUtil.Db.SubmitChanges();
            }
            else
            {
                leaderorg = DbUtil.Db.Organizations.SingleOrDefault(o =>
                    o.OrganizationId == DbUtil.Settings("GODisciplesLeadersOrgId", "0").ToInt());
                neworg = DbUtil.Db.Organizations.SingleOrDefault(o =>
                    o.OrganizationName == groupname);
            }

            g.SetAdmin(discuser, true);
            g.SetBlogger(discuser, true);
            g.SetMember(discuser, true);

            var leaderg = DiscData.Group.LoadByName(DbUtil.Settings("GoDisciplesLeadersGroup",
                STR_GODisciplesLeaders));
            if (leaderg == null)
            {
                DiscData.Group.InsertWithRolesOnSubmit(STR_GODisciplesLeaders);
                DiscData.DbUtil.Db.SubmitChanges();
                leaderg = DiscData.Group.LoadByName(STR_GODisciplesLeaders);
            }
            leaderg.SetMember(discuser, true);
            discuser.DefaultGroup = leaderg.Name;

            DiscData.DbUtil.Db.SubmitChanges();

            // make member of leaders
            OrganizationMember.InsertOrgMembers(leaderorg.OrganizationId, person.PeopleId,
                (int)OrganizationMember.MemberTypeCode.Member,
                DateTime.Now, null, false);

            // make leader of own new org
            OrganizationMember.InsertOrgMembers(neworg.OrganizationId, person.PeopleId,
                (int)OrganizationMember.MemberTypeCode.Leader,
                DateTime.Now, null, false);
        }
        public void PerformMemberSetup()
        {
            OrganizationMember.InsertOrgMembers(neworg.OrganizationId, person.PeopleId,
                (int)OrganizationMember.MemberTypeCode.Member,
                DateTime.Now, null, false);
            MakeDiscUser();
            if (!person.EmailAddress.HasValue())
                person.EmailAddress = email;
            var g = DiscData.Group.LoadByName(neworg.OrganizationName);
            g.SetMember(discuser, true);
            discuser.DefaultGroup = g.Name;
            discuser.ForceLogin = true;
            DiscData.DbUtil.Db.SubmitChanges();
        }
        public static void RenameGroups(string oldname, string newname)
        {
            var g = DiscData.Group.LoadByName(oldname);
            if (g != null)
            {
                g.Name = newname;
                var bname = oldname.Replace(" ", "") + "Blog";
                var b = DiscData.Blog.LoadByName(bname);
                b.Title = newname + " Blog";
                b.Name = b.Title.Replace(" ", "");
                var q = from u in DiscData.DbUtil.Db.Users
                        where u.DefaultGroup == oldname
                        select u;
                foreach (var u in q)
                    u.DefaultGroup = newname;
                DiscData.DbUtil.Db.SubmitChanges();
                var cg = DbUtil.Db.Organizations.SingleOrDefault(o => o.OrganizationName == oldname);
                if (cg != null)
                {
                    cg.OrganizationName = newname;
                    DbUtil.Db.SubmitChanges();
                }
            }
        }
        private string _username;
        private string username
        {
            get
            {
                if (_username == null)
                {
                    var q = from u in DbUtil.Db.Users
                            where u.PeopleId == person.PeopleId
                            orderby u.LastActivityDate descending
                            select u;
                    var user = q.FirstOrDefault();
                    if (user != null)
                        _username = user.Username;
                    else
                        _username = MembershipService.FetchUsername(
                            person.PreferredName, person.LastName);
                }
                return _username;
            }
        }
        private string _password;
        private string password
        {
            get
            {
                if (_password == null)
                {
                    var q = from u in DiscData.DbUtil.Db.Users
                            where u.PeopleId == person.PeopleId
                            orderby u.LastActivityDate descending
                            select u;
                    var dser = q.FirstOrDefault();
                    if (dser != null && Membership.Provider.ValidateUser(username, dser.Password))
                        _password = dser.Password;
                    else
                        _password = MembershipService.FetchPassword();
                }
                return _password;
            }
        }
        private void MakeDiscUser()
        {
            bool userexists;
            do
            {
                var q3 = from u in DiscData.DbUtil.Db.Users
                         where u.Username == username
                         where u.PeopleId != person.PeopleId
                         orderby u.LastActivityDate descending
                         select u;
                userexists = q3.SingleOrDefault() != null;
                if (userexists)
                    _username = _username + "1";
            } while (userexists);

            var q2 = from u in DiscData.DbUtil.Db.Users
                     where u.PeopleId == person.PeopleId
                     orderby u.LastActivityDate descending
                     select u;
            discuser = q2.FirstOrDefault();

            if (discuser != null)
            {
                discuser.Password = password;
                discuser.Username = username; // force username to be this name
            }
            else
            {
                discuser = DiscData.BVMembershipProvider.MakeNewUser(
                    username, password, email,
                    true, person.PeopleId);
                discuser = DiscData.DbUtil.Db.Users.Single(u => u.UserId == discuser.UserId);
                discuser.FirstName = person.PreferredName;
                discuser.LastName = person.LastName;
                discuser.BirthDay = person.GetBirthdate();
            }
            DiscData.DbUtil.Db.SubmitChanges();
        }
        private void MakeUserOnCms()
        {
            const string STR_Attendance = "Attendance";
            const string STR_Staff = "Staff";
            var user = DbUtil.Db.Users.FirstOrDefault(u => u.Username == username);
            if (user != null)
            {
                MembershipService.ChangePassword(username, password);
                user = DbUtil.Db.Users.FirstOrDefault(u => u.Username == username);
                var roles = user.Roles.ToList();
                if (!roles.Contains(STR_Attendance))
                    roles.Add(STR_Attendance);
                if (!roles.Contains(STR_Staff))
                    roles.Add(STR_Staff);
                user.Roles = roles.ToArray();
            }
            else
            {
                user = MembershipService.CreateUser(person.PeopleId, username, password);
                user.Roles = new string[] { "OrgMembersOnly", STR_Attendance, STR_Staff };
            }
            DbUtil.Db.SubmitChanges();
        }
        public void EmailLeaderNotices()
        {
            string adminmail = DbUtil.Settings("GODisciplesMail", DbUtil.SystemEmailAddress);
            var c = DbUtil.Content("GODisciplesLeaderConfirm");
            if (c == null)
                return;
            var p = person;
            var Body = c.Body;
            Body = Body.Replace("{first}", p.PreferredName);
            Body = Body.Replace("{username}", discuser.Username);
            Body = Body.Replace("{password}", discuser.Password);
            Body = Body.Replace("{groupname}", neworg.OrganizationName);
            Body = Body.Replace("{membersignupurl}", MemberSignupUrl);
            Body = Body.Replace("{cmsorgpageurl}", CmsOrgPageUrl);
            Body = Body.Replace("{minister}", DbUtil.Settings("GODisciplesMinister", "GO Disciples Team"));
            Body = Body.Replace("{disciplesurl}", DbUtil.Settings("GODisciplesURL", Util.ResolveServerUrl("~/Disciples/")));

            var smtp = new SmtpClient();
            Util.Email(smtp, adminmail, p.Name, email, c.Title, Body);
            Util.Email2(smtp, email, adminmail, "new GO leader registration in cms",
                "{0}({1},{2}) joined {3}\r\nand has {4} own {5}".Fmt(
                p.Name, p.PeopleId, discuser.Username, leaderorg.OrganizationName,
                p.GenderId == 2 ? "her" : "his",
                neworg.OrganizationName));

            UpdateEmailPhone(smtp, adminmail, p);
        }
        public void EmailMemberNotices()
        {
            string adminmail = DbUtil.Settings("GODisciplesMail", DbUtil.SystemEmailAddress);
            var c = DbUtil.Content("GODisciplesConfirm");
            if (c == null)
                return;
            var p = person;
            var Body = c.Body;
            Body = Body.Replace("{first}", p.PreferredName);
            Body = Body.Replace("{username}", discuser.Username);
            Body = Body.Replace("{password}", discuser.Password);
            Body = Body.Replace("{groupname}", neworg.OrganizationName);
            Body = Body.Replace("{minister}", DbUtil.Settings("GODisciplesMinister", "GO Disciples Team"));
            Body = Body.Replace("{disciplesurl}", DbUtil.Settings("GODisciplesURL", Util.ResolveServerUrl("~/Disciples/")));

            var smtp = new SmtpClient();
            Util.Email(smtp, adminmail, p.Name, email, c.Title, Body);
            Util.Email2(smtp, email, adminmail, "new GO disciple registration in cms",
                "{0}({1},{2}) joined {3}".Fmt(p.Name, p.PeopleId, discuser.Username, neworg.OrganizationName));
            var q = from om in neworg.OrganizationMembers
                    where om.MemberTypeId == neworg.LeaderMemberTypeId
                    select om.Person;
            var leader = q.FirstOrDefault();
            if (leader != null)
                Util.Email2(smtp, email, leader.EmailAddress, "new GO disciple registration",
                    "{0}({1},{2}) joined {3}".Fmt(p.Name, p.PeopleId, discuser.Username, neworg.OrganizationName));
            UpdateEmailPhone(smtp, adminmail, p);
        }
        private void UpdateEmailPhone(SmtpClient smtp, string adminmail, Person p)
        {
            if (email != p.EmailAddress && preferredemail)
            {
                const string subject = "updated email address";
                const string message =
@"We have updated your email address from {0} to {1}.<br />
If this is not correct, please reply and let us know.";

                Util.Email(smtp, adminmail, p.Name, email, subject,
                    message.Fmt(p.EmailAddress, email));
                Util.Email(smtp, adminmail, p.Name, p.EmailAddress, subject,
                    message.Fmt(p.EmailAddress, email));
                p.EmailAddress = email;
            }
            if (homecell == "c" && !p.CellPhone.EndsWith(phone.GetDigits()))
            {
                const string subject = "updated cell phone";
                const string message =
@"We have updated your cell phone from {0} to {1}.<br />
If this is not correct, please reply and let us know.";
                var oldphone = p.CellPhone.FmtFone();
                if (oldphone.HasValue())
                    Util.Email(smtp, adminmail, p.Name, p.EmailAddress, subject,
                        message.Fmt(oldphone, phone.FmtFone()));
                p.CellPhone = phone;
            }
            DbUtil.Db.SubmitChanges();
        }
    }
}
