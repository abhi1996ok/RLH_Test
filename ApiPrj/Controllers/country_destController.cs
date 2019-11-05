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
    public class country_destController : Controller
    {
        rlh_dataEntities2 db = new rlh_dataEntities2();
        // GET: country_dest
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCountPackage( string name)
        {
            var id = db.country_dest_master.Where(y => y.Country_Name == name).ToList().Select(z => z.C_CDM_id).ToList().FirstOrDefault();
            var packId = db.package_dest_master.Where(p => p.C_CDM_id == id).Include(m => m.package_master).ToList();
            PackageMaster package = new PackageMaster();
            return Json(package.PackConvter2(packId.ToList()), JsonRequestBehavior.AllowGet);
        }
    }
}