﻿using MediatR;

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
        public bool ActiveAccount { get; set; }
    }
}
