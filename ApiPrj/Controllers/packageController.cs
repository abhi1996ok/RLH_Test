using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using rlhTest.Models.HelperModel;
using rlhTest.Models.DataModel;

namespace ApiPrj.Controllers
{
    public class packageController : Controller
    {
        private rlh_dataEntities2 db = new rlh_dataEntities2();
        // GET: package
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAllPackage()
        {
            PackageMaster package = new PackageMaster();
            //return new HttpStatusCodeResult(HttpStatusCode.OK);                
            return Json(package.PackConvter(db.package_master.ToList()), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetPackByCount(int person)
        {
            if (person == 2)
            {
                List<package_master> packages = db.package_master.Where(e => e.Booking_Count == person).ToList();
                PackageMaster package = new PackageMaster();
                return Json(package.PackConvter(packages),JsonRequestBehavior.AllowGet);
            }
            else if ((person > 2) && (person < 7))
            {
              List<package_master> packages = db.package_master.Where(e => e.Booking_Count > 2 && e.Booking_Count < 7).ToList();
                PackageMaster package = new PackageMaster();
                return Json(package.PackConvter(packages), JsonRequestBehavior.AllowGet);  
            }
            else if (person >= 7)
            {
                List<package_master> packages = db.package_master.Where(e => e.Booking_Count  > 7).ToList();
                PackageMaster package = new PackageMaster();
                return Json(package.PackConvter(packages), JsonRequestBehavior.AllowGet);
                

            }
            else
            {
                List<package_master> packages = db.package_master.Where(e => e.Booking_Count != 0).ToList();
                PackageMaster package = new PackageMaster();
                return Json(package.PackConvter(packages), JsonRequestBehavior.AllowGet);

            }

        }

    }
}