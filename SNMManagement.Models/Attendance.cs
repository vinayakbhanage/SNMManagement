using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SNMManagement.Models
{
    public class Attendance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }

        [Required]
        public string AttendanceStatus { get; set; }

        public string Remarks { get; set; }

        [Required]
        public int SatsangId { get; set; }
        public Satsang Satsang { get; set; }

        [Required]
        public int SewadarId { get; set; }
        public Sewadar Sewadar { get; set; }

    }
}
