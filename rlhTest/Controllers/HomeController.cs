using rlhTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using rlhTest.Models.HelperModel;

namespace rlhTest.Controllers 
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Packages()
        {
            packConnect connect = new packConnect();
            return View(connect.GetPackages(2, true));
        }

        public PartialViewResult packageView()
        {
            return PartialView();
        }

       
    }
}