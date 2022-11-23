using AutoMapper;
using MediatR;
using Planner.Application.ViewModels;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Queries
{
    public class GetEmployeesQueryHandler : IRequestHandler<GetEmployeesQuery, List<EmployeeViewModel>>
    {

        private readonly IRepository<Employee> _employeeRepository;
        private readonly IMapper _mapper;

        public GetEmployeesQueryHandler(IRepository<Employee> employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<List<EmployeeViewModel>> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
        {
            var employees = _employeeRepository.GetAll();
            List<EmployeeViewModel> result = new List<EmployeeViewModel>();

            foreach(var i in employees)
            {

                var employee = _mapper.Map<EmployeeViewModel>(i);
                result.Add(employee);
            }

            
            return result;
        }

       
    }
}
