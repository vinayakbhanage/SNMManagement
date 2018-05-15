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
    public class AttendanceController : ApiController
    {
        private SNMEntities db = new SNMEntities();

        // GET: api/Attendance
        public IQueryable<Attendance> GetAttendances()
        {
            return db.Attendances.Include(a => a.Satsang).Include(a => a.Sewadar).OrderByDescending(m => m.ID);
        }

        // GET: api/Attendance/5
        [ResponseType(typeof(Attendance))]
        public IHttpActionResult GetAttendance(decimal id)
        {
            Attendance attendance = db.Attendances.Find(id);
            if (attendance == null)
            {
                return NotFound();
            }

            return Ok(attendance);
        }

        // PUT: api/Attendance/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAttendance(decimal id, Attendance attendance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != attendance.ID)
            {
                return BadRequest();
            }

            db.Entry(attendance).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AttendanceExists(id))
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

        // POST: api/Attendance
        [ResponseType(typeof(Attendance))]
        public IHttpActionResult PostAttendance(Attendance attendance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Attendances.Add(attendance);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = attendance.ID }, attendance);
        }

        // DELETE: api/Attendance/5
        [ResponseType(typeof(Attendance))]
        public IHttpActionResult DeleteAttendance(decimal id)
        {
            Attendance attendance = db.Attendances.Find(id);
            if (attendance == null)
            {
                return NotFound();
            }

            db.Attendances.Remove(attendance);
            db.SaveChanges();

            return Ok(attendance);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AttendanceExists(decimal id)
        {
            return db.Attendances.Count(e => e.ID == id) > 0;
        }
    }
}