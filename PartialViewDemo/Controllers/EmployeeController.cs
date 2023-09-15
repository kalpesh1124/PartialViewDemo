using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViewDemo.Models;

namespace PartialViewDemo.Controllers
{
    public class EmployeeController : Controller
    {
        SEEDEntities db = new SEEDEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult CreatePartial()
        {
            ViewBag.msg = "Welcome Employee!!!!";
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult CreatePartial(Employee e1)
        {
            db.Employees.Add(e1);
            db.SaveChanges();
            ViewBag.msg = "Employee Added Successfully";
            return PartialView();
        }
        public PartialViewResult DisplayPartial()
        {
            List<Employee> lemp = db.Employees.ToList();
            return PartialView(lemp);
        }
	}
}