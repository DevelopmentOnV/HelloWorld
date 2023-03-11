using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Collegemanagment.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Course()
        {

            return View();

        }
       
        public ActionResult Anoucement()
        {
            return View();
        }
        public ActionResult Activity()
        {
            return View();
        }
        public ActionResult Contanct()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}