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
    public class DutyGroupsController : ApiController
    {
        private SNMContext db = new SNMContext();

        // GET: api/DutyGroups
        public IQueryable<DutyGroup> GetDutyGroups()
        {
            return db.DutyGroups;
        }

        // GET: api/DutyGroups/5
        [ResponseType(typeof(DutyGroup))]
        public IHttpActionResult GetDutyGroup(int id)
        {
            DutyGroup dutyGroup = db.DutyGroups.Find(id);
            if (dutyGroup == null)
            {
                return NotFound();
            }

            return Ok(dutyGroup);
        }

        // PUT: api/DutyGroups/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDutyGroup(int id, DutyGroup dutyGroup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dutyGroup.Id)
            {
                return BadRequest();
            }

            db.Entry(dutyGroup).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DutyGroupExists(id))
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

        // POST: api/DutyGroups
        [ResponseType(typeof(DutyGroup))]
        public IHttpActionResult PostDutyGroup(DutyGroup dutyGroup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DutyGroups.Add(dutyGroup);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = dutyGroup.Id }, dutyGroup);
        }

        // DELETE: api/DutyGroups/5
        [ResponseType(typeof(DutyGroup))]
        public IHttpActionResult DeleteDutyGroup(int id)
        {
            DutyGroup dutyGroup = db.DutyGroups.Find(id);
            if (dutyGroup == null)
            {
                return NotFound();
            }

            db.DutyGroups.Remove(dutyGroup);
            db.SaveChanges();

            return Ok(dutyGroup);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DutyGroupExists(int id)
        {
            return db.DutyGroups.Count(e => e.Id == id) > 0;
        }
    }
}