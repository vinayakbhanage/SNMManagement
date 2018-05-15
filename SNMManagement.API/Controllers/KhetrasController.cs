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
using SNMManagement.Models;

namespace SNMManagement.API.Controllers
{
    public class KhetrasController : ApiController
    {
        private SNMManagementContext db = new SNMManagementContext();

        // GET: api/Khetras
        public IQueryable<Khetra> GetKhetras()
        {
            return db.Khetras;
        }

        // GET: api/Khetras/5
        [ResponseType(typeof(Khetra))]
        public IHttpActionResult GetKhetra(int id)
        {
            Khetra khetra = db.Khetras.Find(id);
            if (khetra == null)
            {
                return NotFound();
            }

            return Ok(khetra);
        }

        // PUT: api/Khetras/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKhetra(int id, Khetra khetra)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != khetra.Id)
            {
                return BadRequest();
            }

            db.Entry(khetra).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KhetraExists(id))
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

        // POST: api/Khetras
        [ResponseType(typeof(Khetra))]
        public IHttpActionResult PostKhetra(Khetra khetra)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Khetras.Add(khetra);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = khetra.Id }, khetra);
        }

        // DELETE: api/Khetras/5
        [ResponseType(typeof(Khetra))]
        public IHttpActionResult DeleteKhetra(int id)
        {
            Khetra khetra = db.Khetras.Find(id);
            if (khetra == null)
            {
                return NotFound();
            }

            db.Khetras.Remove(khetra);
            db.SaveChanges();

            return Ok(khetra);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KhetraExists(int id)
        {
            return db.Khetras.Count(e => e.Id == id) > 0;
        }
    }
}