using SNMManagement.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SNMManagement.DataAccess
{
    public class SNMContext: DbContext
    {
        public DbSet<Area> Area { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<DutyChart> DutyChart { get; set; }
        public DbSet<DutyGroup> DutyGroup { get; set; }
        public DbSet<Khetra> Khetra { get; set; }
        public DbSet<Mahatma> Mahatma { get; set; }
        public DbSet<Satsang> Satsang { get; set; }
        public DbSet<SatsangType> SatsangType { get; set; }
        public DbSet<Sewadar> Sewadar { get; set; }
        public DbSet<SewadarDesignation> SewadarDesignation { get; set; }
        public DbSet<Unit> Unit { get; set; }
    }
}
