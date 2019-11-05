 using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using rlhTest.Models;
using rlhTest.Models.HelperModel;

namespace ApiPrj.Controllers
{
    public class keyword_masterController : ApiController
    {
        //private rlh_dataEntities db = new rlh_dataEntities();

        //// GET: api/keyword_master
        //public IQueryable<keyword_master> Getkeyword_master()
        //{
        //    return db.keyword_master;
        //}

        //// GET: api/keyword_master/5
        //[ResponseType(typeof(keyword_master))]
        //public async Task<IHttpActionResult> Getkeyword_master(int id)
        //{
        //    keyword_master keyword_master =  db.keyword_master.Find(id);
        //    if (keyword_master == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(keyword_master);
        //}

        //// GET: api/keyword_master/5?type=honeymoon
        //[ResponseType(typeof(keyword_master))]
        //public async Task<IHttpActionResult> Getkeyword_master(int id,string type)
        //{
        //   var res =  db.keyword_master.Where(x=>x.Keyword_Name==type).Include(y=>y.package_master).ToList();
        //    if (res == null)
        //    {
        //        return NotFound();
        //    }
            
        //    PackageMaster pck = new PackageMaster();
           
        //    return Ok(pck.PackConvter(res[0].package_master.ToList()));
        //}

        //// PUT: api/keyword_master/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> Putkeyword_master(int id, keyword_master keyword_master)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != keyword_master.C_KM_id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(keyword_master).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!keyword_masterExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/keyword_master
        //[ResponseType(typeof(keyword_master))]
        //public async Task<IHttpActionResult> Postkeyword_master(keyword_master keyword_master)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.keyword_master.Add(keyword_master);

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (keyword_masterExists(keyword_master.C_KM_id))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtRoute("DefaultApi", new { id = keyword_master.C_KM_id }, keyword_master);
        //}

        //// DELETE: api/keyword_master/5
        //[ResponseType(typeof(keyword_master))]
        //public async Task<IHttpActionResult> Deletekeyword_master(int id)
        //{
        //    keyword_master keyword_master = await db.keyword_master.FindAsync(id);
        //    if (keyword_master == null)
        //    {
        //        return NotFound();
        //    }

        //    db.keyword_master.Remove(keyword_master);
        //    await db.SaveChangesAsync();

        //    return Ok(keyword_master);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool keyword_masterExists(int id)
        //{
        //    return db.keyword_master.Count(e => e.C_KM_id == id) > 0;
        //}
    }
}