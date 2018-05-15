using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SNMManagement.Models
{
    public class Area
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public int UnitId { get; set; }

        public Unit Unit { get; set; }
        public ICollection<DutyChart> DutyCharts { get; set; }

        public ICollection<Satsang> Satsangs { get; set; }
    }
}
