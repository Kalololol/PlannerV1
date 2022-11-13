using System.ComponentModel.DataAnnotations;

namespace Planner.WebBlazor.Models
{
    public class CreateEmployee
    {
        
            [Required]
            [StringLength(50)]
            public string Name { get; set; }
            [Required]
            [StringLength(100)]
            public string Surname { get; set; }
            [Required]
            [EmailAddress]
            public string AddressEmail { get; set; }
            [Required]
            [StringLength(11)]
            public string PhoneNumber { get; set; }
            [Required]
            [StringLength(15)]
            public string LicenseNumber { get; set; }
            [Required]
            [StringLength(20)]
            public string Password { get; set; }

        public CreateEmployee()
        {

        }
        public CreateEmployee(string name, string surname, string addressEmail, string phoneNumber, string licenseNumber, string password)
        {
            Name = name;
            Surname = surname;
            AddressEmail = addressEmail;
            PhoneNumber = phoneNumber;
            LicenseNumber = licenseNumber;
            Password = password;
        }
    }
}
