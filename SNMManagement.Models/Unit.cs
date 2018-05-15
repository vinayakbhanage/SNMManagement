using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SNMManagement.Models
{
    public class Unit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int UnitNumber { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }

        public int KhetraId { get; set; }
        public Khetra Khetra { get; set; }

        public ICollection<Area> Areas { get; set; }
        public ICollection<Satsang> Satsangs { get; set; }
        public ICollection<DutyGroup> DutyGroups { get; set; }
    }
}
