using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessClassWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult AllClassesMVC()
        {
            ViewBag.Title = "Yoga, Bootcamp, RPM | The biggest range of gym classes - Goodlife Health Clubs";
            ViewBag.Message = "This page successfully loaded!";

            var db = new Models.FitnessClassDBEntities();
            {
                // LINQ
                var fClass = (from fc in db.FitnessClasses
                              orderby fc.classID
                              ascending
                              select fc)
                              .ToList();

                return View(fClass);
            }
        }

    }
}