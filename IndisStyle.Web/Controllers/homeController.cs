using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndisStyle.Web.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/

        public ActionResult Index()
        {
            return View();
        }


       //home/system
        public ActionResult System()
        {
            return View();
        }

        //home/prosjekt
        public ActionResult Prosjekt()
        {
            return View();
        }

        public ActionResult Omoss()
        {
            return View();
        }
        public ActionResult Behov()
        {
            return View();
        }

        public ActionResult Integrering()
        {
            return View();
        }
        public ActionResult API()
        {
            return View();
        }


        public ActionResult Demo()
        {
            return View();
        }
    }
}
