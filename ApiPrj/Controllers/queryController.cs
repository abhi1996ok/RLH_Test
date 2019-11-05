using rlhTest.Models.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ApiPrj.Controllers
{
    public class queryController : Controller
    {
        rlh_dataEntities2 db = new rlh_dataEntities2();
        // GET: query
        public ActionResult Index()
        {
            return View();
        }
        [System.Web.Http.HttpPost]
        public ActionResult QueryPost([FromBody] query_master query)
        {
           
            db.query_master.Add(query);

            try
            {
                db.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                
            }



            return new HttpStatusCodeResult(200);


        }
    }
}