using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SNMManagement.Models
{
    public class DutyChart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int? Month { get; set; }

        public string MonthDesc { get; set; }

        public int? Year { get; set; }

        public int AreaId { get; set; }
        public Area Area { get; set; }

        public int DutyGroupId { get; set; }
        public DutyGroup DutyGroup { get; set; }
    }
}
