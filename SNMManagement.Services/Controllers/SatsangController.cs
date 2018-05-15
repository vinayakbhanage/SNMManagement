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
using SNMManagement.Services;

namespace SNMManagement.Services.Controllers
{
    public class SatsangController : ApiController
    {
        private SNMEntities db = new SNMEntities();

        // GET: api/Satsang
        public IQueryable<Satsang> GetSatsangs()
        {
            return db.Satsangs;
        }

        // GET: api/Satsang/5
        [ResponseType(typeof(Satsang))]
        public IHttpActionResult GetSatsang(decimal id)
        {
            Satsang satsang = db.Satsangs.Find(id);
            if (satsang == null)
            {
                return NotFound();
            }

            return Ok(satsang);
        }

        // PUT: api/Satsang/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSatsang(decimal id, Satsang satsang)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != satsang.ID)
            {
                return BadRequest();
            }

            db.Entry(satsang).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SatsangExists(id))
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

        // POST: api/Satsang
        [ResponseType(typeof(Satsang))]
        public IHttpActionResult PostSatsang(Satsang satsang)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Satsangs.Add(satsang);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = satsang.ID }, satsang);
        }

        // DELETE: api/Satsang/5
        [ResponseType(typeof(Satsang))]
        public IHttpActionResult DeleteSatsang(decimal id)
        {
            Satsang satsang = db.Satsangs.Find(id);
            if (satsang == null)
            {
                return NotFound();
            }

            db.Satsangs.Remove(satsang);
            db.SaveChanges();

            return Ok(satsang);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SatsangExists(decimal id)
        {
            return db.Satsangs.Count(e => e.ID == id) > 0;
        }
    }
}