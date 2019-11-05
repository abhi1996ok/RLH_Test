using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using rlhTest.Models.DataModel;
using rlhTest.Models.HelperModel;

namespace ApiPrj.Controllers
{
    public class keywordController : Controller
    {
        private rlh_dataEntities2 db = new rlh_dataEntities2();
        // GET: keyword
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult GetOfferPackage()
        {
            string type = "rlh_offer";


            var res = db.keyword_master.Where(x => x.Keyword_Name == type).Include(y => y.package_master).ToList();
            PackageMaster pck = new PackageMaster();
            return Json(pck.PackConvter(res[0].package_master.ToList()), JsonRequestBehavior.AllowGet);

        }

        public ActionResult GetKeyPackage(string type)
        {
            var res = db.keyword_master.Where(x => x.Keyword_Name == type).Include(y => y.package_master).ToList();
            PackageMaster pck = new PackageMaster();
            return Json(pck.PackConvter(res[0].package_master.ToList()), JsonRequestBehavior.AllowGet);
        }
    }
}