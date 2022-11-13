using MediatR;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Command
{
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, Unit>
    {
        private readonly IRepository<Employee> _employeeRepository; 
        public Task<Unit> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {

            var employee = _employeeRepository.GetById(request.Id);

            if(employee != null)
            {
                _employeeRepository.Delete(employee);
            }

            return Task.FromResult(Unit.Value);
        }
    }
}
