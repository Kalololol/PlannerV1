using AutoMapper;
using MediatR;
using Planner.Application.ViewModels;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Queries
{
    public class GetEmployeeByIdQueryHandler : RequestHandler<GetEmployeeByIdQuery, EmployeeViewModel>
    {
        private readonly IRepository<Employee> _employeRepository;
        private readonly IMapper _mapper;

        public GetEmployeeByIdQueryHandler(IRepository<Employee> employeRepository, IMapper mapper)
        {
            _employeRepository = employeRepository;
            _mapper = mapper;
        }

        protected override EmployeeViewModel Handle(GetEmployeeByIdQuery request)
        {
            var employee = this._mapper.Map<EmployeeViewModel>(this._employeRepository.GetById(request.Id));

            return employee;
        }
    }
}
