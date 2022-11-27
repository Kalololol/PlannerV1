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
               cfg.CreateMap<Employee, EmployeeViewModel>().ReverseMap();
               cfg.CreateMap<EmployeeViewModel, AllEmployee>();
               cfg.CreateMap<CreateEmployee, CreateEmployeeCommand>();
               cfg.CreateMap<EmployeeViewModel, EditDetailsEmployee>();
               cfg.CreateMap<EditDetailsEmployee, EditEmployeeCommand>();
               

               cfg.CreateMap<IndispositionViewModel, Indisposition>().ReverseMap();
               cfg.CreateMap<IndispositionViewModel, AllIndisposition>();
               cfg.CreateMap<CreateIndisposition, CreateIndispositionCommand>();
               cfg.CreateMap<IndispositionViewModel, EditIndisposition>();
               cfg.CreateMap<EditIndisposition, EditIndispositionCommand>();

               cfg.CreateMap<ContractViewModel, Contract>().ReverseMap();
               cfg.CreateMap<ContractViewModel, DetailsContract>().ReverseMap();
               cfg.CreateMap<CreateContract, CreateContractCommand>();
               cfg.CreateMap<EditContract, ContractViewModel>();
               cfg.CreateMap<ContractViewModel, EditContract>();
               cfg.CreateMap<EditContract, EditContractCommand>();

               cfg.CreateMap<RequestViewModel, Request>().ReverseMap();
               cfg.CreateMap<RequestViewModel, AllRequest>();
               cfg.CreateMap<CreateRequest, CreateRequestCommand>();
               cfg.CreateMap<RequestViewModel, DetailsRequest>();
               cfg.CreateMap<RequestViewModel, EditRequest>();
               cfg.CreateMap<EditRequest, EditRequestCommand>();


               


           }).CreateMapper();
    }
}
