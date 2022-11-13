using AutoMapper;
using MediatR;
using Planner.Application.ViewModels;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Command
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, Unit>
    {
        private readonly IRepository<Employee> _employeeRepository;
        private readonly IMapper _mapper;

        public CreateEmployeeCommandHandler(IRepository<Employee> employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public Task<Unit> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {

            var employee = new EmployeeViewModel()
            {
                Name = request.Name,
                Surname = request.Surname,
                AddressEmail = request.AddressEmail,
                PhoneNumber = request.PhoneNumber,
                LicenseNumber = request.LicenseNumber,
                Password = request.Password,
                ActiveAccount = true,
            };
            var result = _mapper.Map<Employee>(employee);
            _employeeRepository.Add(result);

            return Task.FromResult(Unit.Value);
        }
    }
}

