using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViewDemo.Controllers
{
    public class PartialViewDemo1Controller : Controller
    {
        //
        // GET: /PartialViewDemo/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Demo()
        {
            return View();
        }
        public ActionResult ShowView()
        {
            return View();
        }
	}
}