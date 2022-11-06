using AutoMapper;
using Planner.Application.Service.Command;
using Planner.Application.ViewModels;
using Planner.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Infrastructure.ContainerConfigurations.AutoMapper
{
    public class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Employee, EmployeeViewModel>().ReverseMap();
                cfg.CreateMap<EmployeeViewModel, CreateEmployeeCommand>();
                cfg.CreateMap<EmployeeViewModel, EditEmployeeCommand>();
            }).CreateMapper();

    }
}

