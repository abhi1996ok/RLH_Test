using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using rlhTest.Models;

namespace ApiPrj.Controllers
{
    //public class query_masterController : ApiController
    //{
    //    private rlh_dataEntities db = new rlh_dataEntities();

    //    // GET: api/query_master
    //    public IQueryable<query_master> Getquery_master()
    //    {
    //        return db.query_master;
    //    }

    //    // GET: api/query_master/5
    //    [ResponseType(typeof(query_master))]
    //    public async Task<IHttpActionResult> Getquery_master(int id)
    //    {
    //        query_master query_master = await db.query_master.FindAsync(id);
    //        if (query_master == null)
    //        {
    //            return NotFound();
    //        }

    //        return Ok(query_master);
    //    }

    //    // PUT: api/query_master/5
    //    [ResponseType(typeof(void))]
    //    public async Task<IHttpActionResult> Putquery_master(int id, query_master query_master)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        if (id != query_master.C_QM_id)
    //        {
    //            return BadRequest();
    //        }

    //        db.Entry(query_master).State = EntityState.Modified;

    //        try
    //        {
    //            await db.SaveChangesAsync();
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!query_masterExists(id))
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

    //    // POST: api/query_master
    //    [ResponseType(typeof(query_master))]
    //    public async Task<IHttpActionResult> Postquery_master([FromBody]query_master query_master)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        db.query_master.Add(query_master);

    //        try
    //        {
    //            await db.SaveChangesAsync();
    //        }
    //        catch (DbUpdateException)
    //        {
    //            if (query_masterExists(query_master.C_QM_id))
    //            {
    //                return Conflict();
    //            }
    //            else
    //            {
    //                throw;
    //            }
    //        }
    //        catch(DbEntityValidationException ex)
    //        {
    //            foreach (var eve in ex.EntityValidationErrors)
    //            {
    //                Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
    //                    eve.Entry.Entity.GetType().Name, eve.Entry.State);
    //                foreach (var ve in eve.ValidationErrors)
    //                {
    //                    Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
    //                        ve.PropertyName, ve.ErrorMessage);
    //                }
    //            }

    //        }
    //        catch (Exception ex)
    //        {

    //        }

    //        return CreatedAtRoute("DefaultApi", new { id = query_master.C_QM_id }, query_master);
    //    }

    //    // DELETE: api/query_master/5
    //    [ResponseType(typeof(query_master))]
    //    public async Task<IHttpActionResult> Deletequery_master(int id)
    //    {
    //        query_master query_master = await db.query_master.FindAsync(id);
    //        if (query_master == null)
    //        {
    //            return NotFound();
    //        }

    //        db.query_master.Remove(query_master);
    //        await db.SaveChangesAsync();

    //        return Ok(query_master);
    //    }

    //    protected override void Dispose(bool disposing)
    //    {
    //        if (disposing)
    //        {
    //            db.Dispose();
    //        }
    //        base.Dispose(disposing);
    //    }

    //    private bool query_masterExists(int id)
    //    {
    //        return db.query_master.Count(e => e.C_QM_id == id) > 0;
    //    }
    //}
}