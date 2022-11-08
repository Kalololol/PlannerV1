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

        public Task<List<EmployeeViewModel>> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
        {
            var employees = _employeeRepository.GetAll();
            List<EmployeeViewModel> result = new List<EmployeeViewModel>();

            foreach(var i in employees)
            {
                var employee = _mapper.Map<EmployeeViewModel>(i);
                result.Add(employee);
            }

            return Task.FromResult(result);
        }

       /* RequestHandler zaminiełem na IRequestHandler
        * protected override List<EmployeeViewModel> Handle(GetEmployeesQuery request)
        {
            var employees = _employeeRepository.GetAll();
            var employeeViewModel= new List<EmployeeViewModel>();

            foreach(var employee in employees)
            {
                var employeeVM = _mapper.Map<EmployeeViewModel>(employee);
                employeeViewModel.Add(employeeVM);
            }

            return employeeViewModel;
        }*/
    }
}
