using MediatR;
using Planner.Application.ViewModels;

namespace Planner.Application.Service.Queries
{
    public class GetContractsQuery : IRequest <List<ContractViewModel>>
    {
    }
}
