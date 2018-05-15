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
    public class SatsangTypesController : ApiController
    {
        private SNMContext db = new SNMContext();

        // GET: api/SatsangTypes
        public IQueryable<SatsangType> GetSatsangTypes()
        {
            return db.SatsangTypes;
        }

        // GET: api/SatsangTypes/5
        [ResponseType(typeof(SatsangType))]
        public IHttpActionResult GetSatsangType(int id)
        {
            SatsangType satsangType = db.SatsangTypes.Find(id);
            if (satsangType == null)
            {
                return NotFound();
            }

            return Ok(satsangType);
        }

        // PUT: api/SatsangTypes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSatsangType(int id, SatsangType satsangType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != satsangType.Id)
            {
                return BadRequest();
            }

            db.Entry(satsangType).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SatsangTypeExists(id))
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

        // POST: api/SatsangTypes
        [ResponseType(typeof(SatsangType))]
        public IHttpActionResult PostSatsangType(SatsangType satsangType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SatsangTypes.Add(satsangType);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = satsangType.Id }, satsangType);
        }

        // DELETE: api/SatsangTypes/5
        [ResponseType(typeof(SatsangType))]
        public IHttpActionResult DeleteSatsangType(int id)
        {
            SatsangType satsangType = db.SatsangTypes.Find(id);
            if (satsangType == null)
            {
                return NotFound();
            }

            db.SatsangTypes.Remove(satsangType);
            db.SaveChanges();

            return Ok(satsangType);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SatsangTypeExists(int id)
        {
            return db.SatsangTypes.Count(e => e.Id == id) > 0;
        }
    }
}