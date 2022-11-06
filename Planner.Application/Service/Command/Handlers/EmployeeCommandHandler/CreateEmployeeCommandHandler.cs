using MediatR;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Command
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, Unit>
    {
        private readonly IRepository<Employee> _employeRepository;

        public CreateEmployeeCommandHandler(IRepository<Employee> employeRepository)
        {
            _employeRepository = employeRepository;
        }

        Task<Unit> IRequestHandler<CreateEmployeeCommand, Unit>.Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = new Employee()
            {
                Name = request.Name,
                Surname = request.Surname,
                AddressEmail = request.AddressEmail,
                PhoneNumber = request.PhoneNumber,
                LicenseNumber = request.LicenseNumber,
                Password = request.Password,
                ActiveAccount = true,
            };

            _employeRepository.Add(employee);

            return Task.FromResult(Unit.Value);

        }
    }
}
