using MyDashBoardAppRp.DB_Emp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyDashBoardAppRp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IndexDashBoard()
        {
            return View();
        }

        public ActionResult EmpTable()
        {
            EmployeeDataEntities ent = new EmployeeDataEntities();

            var data=ent.EmployeeDetails.ToList();

            return View(data);
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