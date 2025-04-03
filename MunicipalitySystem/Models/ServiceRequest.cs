using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MunicipalityManagementSystem.Models
{
    public class ServiceRequest
    {
        [Key]
        public int RequestID { get; set; }

        [Required]
        [Display(Name = "Citizen")]
        public int CitizenID { get; set; }

        [Required(ErrorMessage = "Service type is required")]
        [Display(Name = "Service Type")]
        public required string ServiceType { get; set; }

        [Display(Name = "Request Date")]
        [DataType(DataType.Date)]
        public DateTime RequestDate { get; set; } = DateTime.Now;

        [Display(Name = "Status")]
        public string Status { get; set; } = "Pending";

        [ForeignKey("CitizenID")]
        public required Citizen Citizen { get; set; }
    }
}