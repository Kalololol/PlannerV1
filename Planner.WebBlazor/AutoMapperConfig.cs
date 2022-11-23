using AutoMapper;
using Planner.Application.Service.Command;
using Planner.Application.ViewModels;
using Planner.Domain.Entities;
using Planner.WebBlazor.Models;

namespace Planner.WebBlazor
{
    public class AutoMapperConfig
    {
        public static IMapper Initialize()
           => new MapperConfiguration(cfg =>
           {
               cfg.CreateMap<CreateEmployee, EmployeeViewModel>().ReverseMap();
               cfg.CreateMap<CreateEmployee, CreateEmployeeCommand>().ReverseMap();
               cfg.CreateMap<Employee, EmployeeViewModel>().ReverseMap();
               cfg.CreateMap<EmployeeViewModel, EditDetailsEmployee>().ReverseMap();
               cfg.CreateMap<EditEmployeeCommand, EditDetailsEmployee>().ReverseMap();


           }).CreateMapper();
    }
}
