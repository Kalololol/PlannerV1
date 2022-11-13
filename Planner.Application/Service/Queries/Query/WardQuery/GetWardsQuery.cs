using MediatR;
using Planner.Application.ViewModels;

namespace Planner.Application.Service.Queries
{
    public class GetWardsQuery : IRequest<List<WardViewModel>>
    {
    }
}
