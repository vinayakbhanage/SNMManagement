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
    public class SewadarDesignationsController : ApiController
    {
        private SNMManagementContext db = new SNMManagementContext();

        // GET: api/SewadarDesignations
        public IQueryable<SewadarDesignation> GetSewadarDesignations()
        {
            return db.SewadarDesignations;
        }

        // GET: api/SewadarDesignations/5
        [ResponseType(typeof(SewadarDesignation))]
        public IHttpActionResult GetSewadarDesignation(int id)
        {
            SewadarDesignation sewadarDesignation = db.SewadarDesignations.Find(id);
            if (sewadarDesignation == null)
            {
                return NotFound();
            }

            return Ok(sewadarDesignation);
        }

        // PUT: api/SewadarDesignations/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSewadarDesignation(int id, SewadarDesignation sewadarDesignation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sewadarDesignation.Id)
            {
                return BadRequest();
            }

            db.Entry(sewadarDesignation).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SewadarDesignationExists(id))
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

        // POST: api/SewadarDesignations
        [ResponseType(typeof(SewadarDesignation))]
        public IHttpActionResult PostSewadarDesignation(SewadarDesignation sewadarDesignation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SewadarDesignations.Add(sewadarDesignation);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = sewadarDesignation.Id }, sewadarDesignation);
        }

        // DELETE: api/SewadarDesignations/5
        [ResponseType(typeof(SewadarDesignation))]
        public IHttpActionResult DeleteSewadarDesignation(int id)
        {
            SewadarDesignation sewadarDesignation = db.SewadarDesignations.Find(id);
            if (sewadarDesignation == null)
            {
                return NotFound();
            }

            db.SewadarDesignations.Remove(sewadarDesignation);
            db.SaveChanges();

            return Ok(sewadarDesignation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SewadarDesignationExists(int id)
        {
            return db.SewadarDesignations.Count(e => e.Id == id) > 0;
        }
    }
}