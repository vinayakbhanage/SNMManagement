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
    public class MahatmasController : ApiController
    {
        private SNMManagementContext db = new SNMManagementContext();

        // GET: api/Mahatmas
        public IQueryable<Mahatma> GetMahatmas()
        {
            return db.Mahatmas;
        }

        // GET: api/Mahatmas/5
        [ResponseType(typeof(Mahatma))]
        public IHttpActionResult GetMahatma(int id)
        {
            Mahatma mahatma = db.Mahatmas.Find(id);
            if (mahatma == null)
            {
                return NotFound();
            }

            return Ok(mahatma);
        }

        // PUT: api/Mahatmas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMahatma(int id, Mahatma mahatma)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mahatma.Id)
            {
                return BadRequest();
            }

            db.Entry(mahatma).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MahatmaExists(id))
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

        // POST: api/Mahatmas
        [ResponseType(typeof(Mahatma))]
        public IHttpActionResult PostMahatma(Mahatma mahatma)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Mahatmas.Add(mahatma);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = mahatma.Id }, mahatma);
        }

        // DELETE: api/Mahatmas/5
        [ResponseType(typeof(Mahatma))]
        public IHttpActionResult DeleteMahatma(int id)
        {
            Mahatma mahatma = db.Mahatmas.Find(id);
            if (mahatma == null)
            {
                return NotFound();
            }

            db.Mahatmas.Remove(mahatma);
            db.SaveChanges();

            return Ok(mahatma);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MahatmaExists(int id)
        {
            return db.Mahatmas.Count(e => e.Id == id) > 0;
        }
    }
}