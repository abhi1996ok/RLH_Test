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

namespace ApiPrj.Controllers
{
    public class destination_masterController : ApiController
    {
      //  private rlh_dataEntities db = new rlh_dataEntities();

        //    // GET: api/destination_master
        //    public IHttpActionResult Get()
        //    {
        //        DestinationMaster destination = new DestinationMaster();

        //        return Ok(destination.Converter(db.destination_master.ToList()));
        //    }

        //    // GET: api/destination_master/5
        //    [ResponseType(typeof(destination_master))]
        //    public IHttpActionResult Getdestination_master(int id)
        //    {
        //        destination_master destination_master = db.destination_master.Find(id);
        //        if (destination_master == null)
        //        {
        //            return NotFound();
        //        }

        //        return Ok(destination_master);
        //    }


        //    // GET: api/destination_master/5/true
        //    [ResponseType(typeof(destination_master))]
        //    public IHttpActionResult Getdestination_master(int id,sbyte visa)
        //    {


        //        var res = db.destination_master.Where(e=>e.Visa_Free==visa).ToList();
        //        if (res == null)
        //        {
        //            return NotFound();
        //        }
        //        DestinationMaster destPack = new DestinationMaster();


        //        return Ok(destPack.Converter(res));
        //    }

        //    // GET: api/destination_master/5/true
        //    [ResponseType(typeof(destination_master))]
        //    public IHttpActionResult Getdestination_pack(int id, string destName)
        //    {
        //        var idd = db.destination_master.Where(x => x.Destination_Name == destName).ToList().Select(x => x.C_DM_id).ToList().FirstOrDefault();

        //        //var res = db.destination_master.Include(y => y.package_master).Where(e=>e.Destination_Name==destName).ToList();
        //        var res = db.package_master.Where(x=>x.C_DM_id==idd).ToList();

        //        if (res == null)
        //        {
        //            return NotFound();
        //        }
        //        PackageMaster packageMaster = new PackageMaster();
        //        return Ok(packageMaster.PackConvter(res));
        //    }


        //    // PUT: api/destination_master/5
        //    [ResponseType(typeof(void))]
        //    public IHttpActionResult Putdestination_master(int id, destination_master destination_master)
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return BadRequest(ModelState);
        //        }

        //        if (id != destination_master.C_DM_id)
        //        {
        //            return BadRequest();
        //        }

        //        db.Entry(destination_master).State = EntityState.Modified;

        //        try
        //        {
        //            db.SaveChanges();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!destination_masterExists(id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }

        //        return StatusCode(HttpStatusCode.NoContent);
        //    }

        //    // POST: api/destination_master
        //    [ResponseType(typeof(destination_master))]
        //    public IHttpActionResult Postdestination_master(destination_master destination_master)
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return BadRequest(ModelState);
        //        }

        //        db.destination_master.Add(destination_master);

        //        try
        //        {
        //            db.SaveChanges();
        //        }
        //        catch (DbUpdateException)
        //        {
        //            if (destination_masterExists(destination_master.C_DM_id))
        //            {
        //                return Conflict();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }

        //        return CreatedAtRoute("DefaultApi", new { id = destination_master.C_DM_id }, destination_master);
        //    }

        //    // DELETE: api/destination_master/5
        //    [ResponseType(typeof(destination_master))]
        //    public IHttpActionResult Deletedestination_master(int id)
        //    {
        //        destination_master destination_master = db.destination_master.Find(id);
        //        if (destination_master == null)
        //        {
        //            return NotFound();
        //        }

        //        db.destination_master.Remove(destination_master);
        //        db.SaveChanges();

        //        return Ok(destination_master);
        //    }

        //    protected override void Dispose(bool disposing)
        //    {
        //        if (disposing)
        //        {
        //            db.Dispose();
        //        }
        //        base.Dispose(disposing);
        //    }

        //    private bool destination_masterExists(int id)
        //    {
        //        return db.destination_master.Count(e => e.C_DM_id == id) > 0;
        //    }
        //}
    }
}