﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CmsData;
using CmsWeb.Models.iPhone;
using CmsWeb.MobileAPI;
using UtilityExtensions;

namespace CmsWeb.Areas.Public.Controllers
{
	public class MobileAPIController : Controller
	{
		public ActionResult Authorize()
		{
			BaseReturn br = new BaseReturn();

			if (SystemHelper.Authenticate()) return br;
			else
			{
				br.error = 1;
				br.data = "Username and password combination not found, please try again.";
				return br;
			}
		}

		public ActionResult Search(string name, string comm, string addr)
		{
			BaseReturn br = new BaseReturn();
			List<MobilePerson> mp = new List<MobilePerson>();

			var m = new SearchModel(name, comm, addr);

			br.type = 1;
			br.count = m.Count;

			foreach( var item in m.ApplySearch().OrderBy(p => p.Name2).Take(20) )
			{
				mp.Add(new MobilePerson().populate(item));
			}

			br.data = JSONHelper.JsonSerializer<List<MobilePerson>>(mp);
			return br;
		}

		public ActionResult TaskList( int ID )
		{
			BaseReturn br = new BaseReturn();
			List<MobileTask> mt = new List<MobileTask>();

			var list = from e in DbUtil.Db.Tasks
					   where e.OwnerId == ID
					   select e;

			br.type = 101;

			if (list != null)
			{
				br.count = list.Count();

				foreach (var item in list)
				{
					mt.Add(new MobileTask().populate(item));
				}

				br.data = JSONHelper.JsonSerializer<List<MobileTask>>(mt);
			}
			else
			{
				br.error = 1;
			}

			return br;
		}

		public ActionResult TaskItem( int ID )
		{
			BaseReturn br = new BaseReturn();
			MobileTask mt = new MobileTask();

			var item = (from e in DbUtil.Db.Tasks
					   where e.Id == ID
					   select e).SingleOrDefault();

			br.type = 102;

			if (item != null)
			{
				br.count = 1;

				mt.populate(item);
				br.data = JSONHelper.JsonSerializer<MobileTask>(mt);
			}
			else
			{
				br.error = 1;
			}
			
			return br;
		}

		public ActionResult TaskBoxList( int ID )
		{
			BaseReturn br = new BaseReturn();
			List<MobileTaskBox> mtb = new List<MobileTaskBox>();

			var list = from e in DbUtil.Db.TaskLists
					   where e.CreatedBy == ID
					   select e;

			br.type = 103;

			if (list != null)
			{
				br.count = list.Count();

				foreach (var item in list)
				{
					mtb.Add(new MobileTaskBox().populate(item));
				}

				br.data = JSONHelper.JsonSerializer<List<MobileTaskBox>>(mtb);
			}
			else
			{
				br.error = 1;
			}

			return br;
		}

		public ActionResult TaskBoxItem( int ID )
		{
			BaseReturn br = new BaseReturn();
			MobileTaskBox mtb = new MobileTaskBox();

			var item = (from e in DbUtil.Db.TaskLists
					   where e.CreatedBy == ID
					   select e).SingleOrDefault();

			br.type = 104;

			if (item != null)
			{
				br.count = 1;

				mtb.populate(item);
				br.data = JSONHelper.JsonSerializer<MobileTaskBox>(mtb);
			}
			else
			{
				br.error = 1;
			}

			return br;
		}
	}

	public class BaseReturn : ActionResult
	{
		public int error = 0;
		public int type = 0;
		public int count = 0;
		public string data = "";

		public override void ExecuteResult(ControllerContext context)
		{
			context.HttpContext.Response.ContentType = "application/json";
			context.HttpContext.Response.Output.Write(JSONHelper.JsonSerializer<BaseReturn>(this));
		}
	}
}