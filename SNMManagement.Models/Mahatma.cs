using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SNMManagement.Models
{
    public class Mahatma
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Select Gender")]
        [Required]
        public string Gender { get; set; }

        public string BloodGroup { get; set; }

        [Display(Name = "Date of Birth")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Display(Name = "Residential Address")]
        public string ResidentialAddress { get; set; }

        [Display(Name = "Permanant Address")]
        public string PermanentAddress { get; set; }

        [Display(Name = "Mobile Number")]
        [Required]
        [MinLength(10, ErrorMessage = "Entered Mobile number is not correct")]
        public string Mobile { get; set; }

        [Display(Name = "Office Address")]
        public string OfficeAddress { get; set; }

        [Display(Name = "Office Telephone")]
        public string OfficeTelephone { get; set; }

        [Display(Name = "Year when Gyan is taken")]
        public string GyanTakenYear { get; set; }

        [Display(Name = "Corpus Account No")]
        public string CorpusAccountNo { get; set; }

        [Display(Name = "No of Family Members")]
        public int? FamilyCount { get; set; }

        [Display(Name = "Qualification")]
        public string Qualification { get; set; }

        [Display(Name = "Occupation")]
        public string Occupation { get; set; }

        [Display(Name = "Special Qualities")]
        public string SpecialQualities { get; set; }

        public byte[] Photo { get; set; }

        public string Email { get; set; }

        public ICollection<Sewadar> Sewadars { get; set; }
    }
}
