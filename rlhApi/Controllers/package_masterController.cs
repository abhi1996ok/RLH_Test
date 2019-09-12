using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using rlhTest.Models;
using rlhTest.Models.HelperModel;

namespace rlhApi.Controllers
{
    public class package_masterController : ApiController
    {
        private rlh_dataEntities db = new rlh_dataEntities();

        // GET: api/package_master
        public IQueryable<package_master> Getpackage_master()
        {
            return db.package_master;
        }

        // GET: api/package_master/5
        [ResponseType(typeof(package_master))]
        public IHttpActionResult Getpackage_master(int id)
        {
            package_master package_master = db.package_master.Find(id);
            if (package_master == null)
            {
                return NotFound();
            }

            return Ok(package_master);
        }

        //GET: api/package_master/5/true
        [ResponseType(typeof(package_master))]
        public HttpResponseMessage Getpackage_master(int id, bool destId)
        {
            if (destId == false)
            {
                package_master package_master = db.package_master.Find(id);
                if (package_master == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, package_master);
            }
            else
            {
                List<package_master> package_master = db.package_master.Where(e => e.C_DM_id == id).ToList();
                if (package_master == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
                PackageMaster pck = new PackageMaster();

                return Request.CreateResponse(HttpStatusCode.OK, pck.PackConvter(package_master));

            }

        }

        // PUT: api/package_master/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putpackage_master(int id, package_master package_master)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != package_master.C_PM_id)
            {
                return BadRequest();
            }

            db.Entry(package_master).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!package_masterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/package_master
        [ResponseType(typeof(package_master))]
        public IHttpActionResult Postpackage_master(package_master package_master)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.package_master.Add(package_master);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (package_masterExists(package_master.C_PM_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = package_master.C_PM_id }, package_master);
        }

        // DELETE: api/package_master/5
        [ResponseType(typeof(package_master))]
        public IHttpActionResult Deletepackage_master(int id)
        {
            package_master package_master = db.package_master.Find(id);
            if (package_master == null)
            {
                return NotFound();
            }

            db.package_master.Remove(package_master);
            db.SaveChanges();

            return Ok(package_master);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool package_masterExists(int id)
        {
            return db.package_master.Count(e => e.C_PM_id == id) > 0;
        }
    }
}