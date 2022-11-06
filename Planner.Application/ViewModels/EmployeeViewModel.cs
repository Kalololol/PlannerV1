using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Planner.Application.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Imię")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Nazwisko")]
        public string Surname { get; set; }
        [Required]
        [DisplayName("Numer telefonu")]
        public string PhoneNumber { get; set; }
        [Required]
        [DisplayName("Prawo wyk. zawodu")]
        public string LicenseNumber { get; set; }

    }
}
