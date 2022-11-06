using AutoMapper;
using MediatR;
using Planner.Application.ViewModels;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Queries
{
    public class GetEmployeesQueryHandler : RequestHandler<GetEmployeesQuery, List<EmployeeViewModel>>
    {

        private readonly IRepository<Employee> _employeeRepository;
        private readonly IMapper _mapper;

        public GetEmployeesQueryHandler(IRepository<Employee> employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        protected override List<EmployeeViewModel> Handle(GetEmployeesQuery request)
        {
            var employees = _employeeRepository.GetAll().ToList();
            var employeeViewModel = new List<EmployeeViewModel>();

            foreach(var employee in employees)
            {
                var employeeVM = _mapper.Map<EmployeeViewModel>(employee);
                employeeViewModel.Add(employeeVM);
            }

            return employeeViewModel;
        }
    }
}
