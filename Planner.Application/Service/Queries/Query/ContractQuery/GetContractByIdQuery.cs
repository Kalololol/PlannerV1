using MediatR;
using Planner.Application.ViewModels;

namespace Planner.Application.Service.Queries
{
    public class GetContractByIdQuery : IRequest <ContractViewModel> 
    {
        public int Id { get; set; }
    }
}
