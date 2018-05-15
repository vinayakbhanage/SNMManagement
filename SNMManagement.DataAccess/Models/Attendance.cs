using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SNMManagement.DataAccess.Models
{
    public class Attendance
    {
        public Int64 Id { get; set; }

        [Required]
        public decimal SatsangId { get; set; }

        [Required]
        public decimal SewadarId { get; set; }

        [Required]
        public string AttendanceStatus { get; set; }

        public string Remarks { get; set; }

        public virtual Satsang Satsang { get; set; }

        public virtual Sewadar Sewadar { get; set; }
    }
}
