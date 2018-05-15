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
    public class DutyChartsController : ApiController
    {
        private SNMContext db = new SNMContext();

        // GET: api/DutyCharts
        public IQueryable<DutyChart> GetDutyCharts()
        {
            return db.DutyCharts;
        }

        // GET: api/DutyCharts/5
        [ResponseType(typeof(DutyChart))]
        public IHttpActionResult GetDutyChart(int id)
        {
            DutyChart dutyChart = db.DutyCharts.Find(id);
            if (dutyChart == null)
            {
                return NotFound();
            }

            return Ok(dutyChart);
        }

        // PUT: api/DutyCharts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDutyChart(int id, DutyChart dutyChart)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dutyChart.Id)
            {
                return BadRequest();
            }

            db.Entry(dutyChart).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DutyChartExists(id))
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

        // POST: api/DutyCharts
        [ResponseType(typeof(DutyChart))]
        public IHttpActionResult PostDutyChart(DutyChart dutyChart)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DutyCharts.Add(dutyChart);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = dutyChart.Id }, dutyChart);
        }

        // DELETE: api/DutyCharts/5
        [ResponseType(typeof(DutyChart))]
        public IHttpActionResult DeleteDutyChart(int id)
        {
            DutyChart dutyChart = db.DutyCharts.Find(id);
            if (dutyChart == null)
            {
                return NotFound();
            }

            db.DutyCharts.Remove(dutyChart);
            db.SaveChanges();

            return Ok(dutyChart);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DutyChartExists(int id)
        {
            return db.DutyCharts.Count(e => e.Id == id) > 0;
        }
    }
}