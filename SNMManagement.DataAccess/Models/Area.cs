using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SNMManagement.DataAccess.Models
{
    public class Area
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal UnitId { get; set; }

        [Required]
        public string Location { get; set; }

        public virtual Unit Unit { get; set; }
        public virtual ICollection<DutyChart> DutyCharts { get; set; }
        public virtual ICollection<Satsang> Satsangs { get; set; }
    }
}
