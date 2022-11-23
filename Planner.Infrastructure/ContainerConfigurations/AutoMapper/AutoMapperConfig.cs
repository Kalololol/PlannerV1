using AutoMapper;
using Planner.Application.Service.Command;
using Planner.Application.ViewModels;
using Planner.Domain.Entities;

namespace Planner.Infrastructure.ContainerConfigurations.AutoMapper
{
    public class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                // cfg.CreateMap<CreateEmployee, EmployeeViewModel>().ReverseMap();
                cfg.CreateMap<Employee, EmployeeViewModel>().ReverseMap();

                cfg.CreateMap<EmployeeViewModel, CreateEmployeeCommand>().ReverseMap();
                cfg.CreateMap<EmployeeViewModel, EditEmployeeCommand>().ReverseMap();
               
                

                cfg.CreateMap<Indisposition, IndispositionViewModel>().ReverseMap();
                

            }).CreateMapper();

    }
}

