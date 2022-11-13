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
        public string AddressEmail { get; set; }
        [Required]
        [DisplayName("Numer telefonu")]
        public string PhoneNumber { get; set; }
        [Required]
        [DisplayName("Prawo wyk. zawodu")]
        public string LicenseNumber { get; set; }
        public string Password { get; set; }
        public bool ActiveAccount { get; set; }

      
    }
}
