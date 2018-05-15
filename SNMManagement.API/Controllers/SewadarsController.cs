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
    public class SewadarsController : ApiController
    {
        private SNMManagementContext db = new SNMManagementContext();

        // GET: api/Sewadars
        public IQueryable<Sewadar> GetSewadars()
        {
            return db.Sewadars;
        }

        // GET: api/Sewadars/5
        [ResponseType(typeof(Sewadar))]
        public IHttpActionResult GetSewadar(int id)
        {
            Sewadar sewadar = db.Sewadars.Find(id);
            if (sewadar == null)
            {
                return NotFound();
            }

            return Ok(sewadar);
        }

        // PUT: api/Sewadars/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSewadar(int id, Sewadar sewadar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sewadar.ID)
            {
                return BadRequest();
            }

            db.Entry(sewadar).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SewadarExists(id))
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

        // POST: api/Sewadars
        [ResponseType(typeof(Sewadar))]
        public IHttpActionResult PostSewadar(Sewadar sewadar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Sewadars.Add(sewadar);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = sewadar.ID }, sewadar);
        }

        // DELETE: api/Sewadars/5
        [ResponseType(typeof(Sewadar))]
        public IHttpActionResult DeleteSewadar(int id)
        {
            Sewadar sewadar = db.Sewadars.Find(id);
            if (sewadar == null)
            {
                return NotFound();
            }

            db.Sewadars.Remove(sewadar);
            db.SaveChanges();

            return Ok(sewadar);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SewadarExists(int id)
        {
            return db.Sewadars.Count(e => e.ID == id) > 0;
        }
    }
}