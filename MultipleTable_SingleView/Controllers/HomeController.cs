using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultipleTable_SingleView.Models;

namespace MultipleTable_SingleView.Controllers
{
    public class HomeController : Controller
    {
        private readonly employeeDBEntities db = new employeeDBEntities();
        public ActionResult Index()
        {
            var tables = new EmployeeViewModel
            {
                Employees = db.Employees.ToList(),
                Departments = db.Departments.ToList(),
                Incentives = db.Incentives.ToList()
            };
            return View(tables);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}