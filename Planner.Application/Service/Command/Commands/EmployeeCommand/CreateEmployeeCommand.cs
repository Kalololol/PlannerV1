using MediatR;
using Planner.Application.ViewModels;

namespace Planner.Application.Service.Command
{
    public class CreateEmployeeCommand : IRequest 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string AddressEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string LicenseNumber { get; set; }
        public string Password { get; set; }

        public CreateEmployeeCommand(){}

        public CreateEmployeeCommand(string name, string surname, string addressEmail, string phoneNumber, string licenseNumber, string password)
        {
            this.Name = name;
            this.Surname = surname;
            this.AddressEmail = addressEmail;
            this.PhoneNumber = phoneNumber;
            this.LicenseNumber = licenseNumber;
            this.Password = password;
        }
    }
}

