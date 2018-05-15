using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SNMManagement.Models
{
    public class Sewadar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Personal No")]
        public string PersonalNo { get; set; }

        [Required]
        [Display(Name = "I Card Number")]
        public int ICardNumber { get; set; }

        [Required]
        [Display(Name = "Weekly Holiday")]
        public string WeeklyHoliday { get; set; }

        [Required]
        [Display(Name = "Select Wing")]
        public int Wing { get; set; }

        public int MahatmaId { get; set; }
        public Mahatma Mahatma { get; set; }

        public int SewadarDesignationId { get; set; }
        public SewadarDesignation SewadarDesignation { get; set; }

        public ICollection<Attendance> Attendances { get; set; }
    }
}
