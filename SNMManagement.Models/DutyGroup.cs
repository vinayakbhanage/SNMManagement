using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SNMManagement.Models
{
    public class DutyGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int UnitId { get; set; }
        public Unit Unit { get; set; }

        public IEnumerable<DutyChart> DutyCharts { get; set; }
    }
}
