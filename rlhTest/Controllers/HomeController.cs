using rlhTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using rlhTest.Models.HelperModel;
using System.Web.Http;
using rlhTest.Models.DataModel;

namespace rlhTest.Controllers
{
    public class HomeController : Controller
    {
        //// get: home
        public ActionResult Index()
        {
            connectClass connect = new connectClass();
            ViewBag.data = connect.GetAllPackages().ToList();
            ViewBag.count = connect.GetAllPackages().ToList().Count();
            return View(connect.GetOfferPack().ToList());

        }

        public ActionResult AllPackages()
        {
            connectClass connect = new connectClass();
            ViewBag.data = connect.GetAllContDest().ToList();
            ViewBag.count = connect.GetAllContDest().ToList().Count();
            return View(connect.GetAllPackages().ToList());
        }

        public ActionResult PackagesByKey(string str)
        {
            connectClass connect = new connectClass();
            return View(connect.GetKeyPackage(str));
        }

        public ActionResult PackagesByDest(string str)
        {
            connectClass connect = new connectClass();
            return View(connect.GetDestAllPack(str));
        }

        public ActionResult QueryRaise([FromBody]query_master query)
        {

            connectClass conn = new connectClass();

            if (conn.PostQuery(query))
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return new HttpStatusCodeResult(502);
            }

             
        }

        /// <summary>
        /// The PackCont Action Method for calling 
        /// packages list view by Continent 
        /// </summary>
        /// <param name="cont"></param>
        /// <returns> return list of the packages 
        /// by continent filter </returns>


        public ActionResult PackCont(string cont)
        {

            connectClass conn = new connectClass();
            ViewBag.data = cont;
            return View(conn.GetPackByCont(cont));


        }

        public ActionResult PackCount(int person)
        {
            connectClass conn = new connectClass();
            ViewBag.data = conn.GetPackByCount(person);
            ViewBag.data1 = conn.GetPackByCount(person).ToList();
            ViewBag.count = conn.GetPackByCount(person).ToList().Count();
            ViewBag.extra = new Filters();
            return View(conn.GetPackByCount(person).ToList());
        }


        ////public ActionResult VisaFree(sbyte visa)
        ////{
        ////    packConnect connect = new packConnect();
        ////    return View(connect.GetVFreeDest(visa));
        ////}

        //public ActionResult PackagesByDest(int id)
        //{
        //    bool dest = true;
        //    packConnect connect = new packConnect();
        //    return View(connect.GetPackages(id,dest));
        //}



        ///// <summary>
        ///// 
        ///// </summary>

        //public ActionResult QueryRaise([FromBody]query_master query)
        //{
        //    query.Seen_By = "";
        //    packConnect conn = new packConnect();

        //    if (conn.PostQuery(query))
        //    {
        //        return  RedirectToAction("Index","Home");
        //    }
        //    else
        //    {
        //        return new HttpStatusCodeResult(502);
        //    }


        //}

        /// <summary>
        /// The list of the Partial View 
        /// </summary>

           // public PartialViewResult

        public PartialViewResult packViewIndex()
        {
            return PartialView();
        }

        public PartialViewResult packageView()
        {
            return PartialView();
        }

        public PartialViewResult destViewIndex()
        {
            return PartialView();
        }

        public PartialViewResult filterView()
        {
            Filters fl = new Filters();
            return PartialView(fl);
        }

    }
}

