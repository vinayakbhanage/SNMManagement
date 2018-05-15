using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SNMManagement.DataAccess.Models
{
    public class Sewadar
    {
        public decimal ID { get; set; }

        [Required]
        [Display(Name = "Personal No")]
        public string PersonalNo { get; set; }

        [Required]
        [Display(Name = "Select Unit")]
        public decimal UnitId { get; set; }

        [Required]
        [Display(Name = "I Card Number")]
        public Nullable<decimal> ICardNumber { get; set; }

        [Required]
        [Display(Name = "Select Duty Group")]
        public decimal DutyGroupId { get; set; }

        [Required]
        [Display(Name = "Weekly Holiday")]
        public string WeeklyHoliday { get; set; }

        [Required]
        [Display(Name = "Select Wing")]
        public Nullable<short> Wing { get; set; }

        [Required]
        [Display(Name = "Select Designation")]
        public int Designation { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual Mahatma Mahatma { get; set; }
        public virtual SewadarDesignation SewadarDesignation { get; set; }
    }
}
