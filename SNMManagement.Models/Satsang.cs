using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SNMManagement.Models
{
    public class Satsang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Satsang Unique Name")]
        [Required]
        public string Title { get; set; }

        public string Note { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Satsang")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true, ConvertEmptyStringToNull = true)]
        public DateTime Date { get; set; }

        [Display(Name = "Stage Duty Mahatma Name")]
        public string StageDutyMahatmaName { get; set; }

        [Display(Name = "Sanchalak Id")]
        public int SanchalakId { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        [Required]
        [Display(Name = "Area of Unit")]
        public int AreaId { get; set; }
        public Area Area { get; set; }

        public ICollection<Attendance> Attendances { get; set; }

        [Required]
        [Display(Name = "Satsang Type")]
        public int SatsangTypeId { get; set; }
        public SatsangType SatsangType { get; set; }

        [Required]
        [Display(Name = "Unit")]
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
    }
}
