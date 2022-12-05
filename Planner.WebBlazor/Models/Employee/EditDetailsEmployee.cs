namespace Planner.WebBlazor.Models
{
    public class EditDetailsEmployee
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? AddressEmail { get; set; }
        public string? PhoneNumber { get; set; }
        public string? LicenseNumber { get; set; }
        public string? Password { get; set; }

        public EditDetailsEmployee(){}

        public EditDetailsEmployee(int? id, string? name, string? surname, string? addressEmail, string? phoneNumber, string? licenseNumber, string? password)
        {
            Id = id;
            Name = name;
            Surname = surname;
            AddressEmail = addressEmail;
            PhoneNumber = phoneNumber;
            LicenseNumber = licenseNumber;
            Password = password;
        }
    }
}
