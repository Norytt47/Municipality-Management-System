using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MunicipalityManagementSystem.Models
{
    public class Report
    {
        [Key]
        public int ReportID { get; set; }

        [Required]
        [Display(Name = "Citizen")]
        public int CitizenID { get; set; }

        [Required(ErrorMessage = "Report type is required")]
        [Display(Name = "Report Type")]
        public required string ReportType { get; set; }

        [Required(ErrorMessage = "Details are required")]
        public required string Details { get; set; }

        [Display(Name = "Submission Date")]
        [DataType(DataType.Date)]
        public DateTime SubmissionDate { get; set; } = DateTime.Now;

        [Display(Name = "Status")]
        public string Status { get; set; } = "Under Review";

        [ForeignKey("CitizenID")]
        public required Citizen Citizen { get; set; }
    }
}