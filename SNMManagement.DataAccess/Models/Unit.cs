using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SNMManagement.DataAccess.Models
{
    public class Unit
    {
        public decimal ID { get; set; }
        public Nullable<decimal> UnitNumber { get; set; }
        public string Name { get; set; }
        public decimal KhetraId { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Area> Areas { get; set; }
        public virtual Khetra Khetra { get; set; }
        public virtual ICollection<Satsang> Satsangs { get; set; }
        public virtual ICollection<DutyGroup> DutyGroups { get; set; }
    }
}
