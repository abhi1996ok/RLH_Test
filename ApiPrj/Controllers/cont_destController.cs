using rlhTest.Models.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using rlhTest.Models.HelperModel;
using System.Net;
using System.Data.Entity;

namespace ApiPrj.Controllers
{
    public class cont_destController : Controller
    {
        private rlh_dataEntities2 db = new rlh_dataEntities2();
        // GET: cont_dest

        public ActionResult Index()
        {
            return View();
        }

  
        public ActionResult GetData()
        {
                ContDestinationMaster destination = new ContDestinationMaster();
                //return new HttpStatusCodeResult(HttpStatusCode.OK);                
                return Json(destination.Converter(db.cont_destination_master.ToList()),JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetPackCont(string contName)
        {
            var id = db.cont_destination_master.Where(s => s.Destination_Name == contName).ToList().Select(e => e.C_Co_DM_id).ToList().FirstOrDefault();
            var pack = db.package_dest_master.Where(f => f.C_Co_DM_id == id).Include(e=>e.package_master).ToList();
            PackageMaster packageMaster = new PackageMaster();
            return Json(packageMaster.PackConvter2(pack.ToList()),JsonRequestBehavior.AllowGet);
        }
    }
}