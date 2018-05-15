using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SNMManagement.DataAccess.Models
{
    public class Satsang
    {
        public int Id { get; set; }

        [Display(Name = "Satsang Unique Name")]
        [Required]
        public string Title { get; set; }

        public string Note { get; set; }

        [Required]
        [Display(Name = "Satsang Type")]
        public decimal SatsangTypeId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Satsang")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true, ConvertEmptyStringToNull = true)]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Unit")]
        public decimal UnitId { get; set; }

        [Required]
        [Display(Name = "Area of Unit")]
        public decimal AreaId { get; set; }

        [Display(Name = "Stage Duty Mahatma Name")]
        public string StageDutyMahatmaName { get; set; }

        [Display(Name = "Sanchalak Id")]
        public Nullable<Int64> SanchalakId { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public virtual Area Area { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }

        public virtual SatsangType SatsangType { get; set; }

        public virtual Unit Unit { get; set; }
    }
}
