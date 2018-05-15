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

namespace SNMManagement.Services.Controllers
{
    public class SatsangsController : ApiController
    {
        private SNMContext db = new SNMContext();

        // GET: api/Satsangs
        public IQueryable<Satsang> GetSatsangs()
        {
            return db.Satsangs;
        }

        // GET: api/Satsangs/5
        [ResponseType(typeof(Satsang))]
        public IHttpActionResult GetSatsang(int id)
        {
            Satsang satsang = db.Satsangs.Find(id);
            if (satsang == null)
            {
                return NotFound();
            }

            return Ok(satsang);
        }

        // PUT: api/Satsangs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSatsang(int id, Satsang satsang)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != satsang.Id)
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

        // POST: api/Satsangs
        [ResponseType(typeof(Satsang))]
        public IHttpActionResult PostSatsang(Satsang satsang)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Satsangs.Add(satsang);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = satsang.Id }, satsang);
        }

        // DELETE: api/Satsangs/5
        [ResponseType(typeof(Satsang))]
        public IHttpActionResult DeleteSatsang(int id)
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

        private bool SatsangExists(int id)
        {
            return db.Satsangs.Count(e => e.Id == id) > 0;
        }
    }
}