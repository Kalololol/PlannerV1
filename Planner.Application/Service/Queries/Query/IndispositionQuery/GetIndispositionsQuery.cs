using MediatR;
using Planner.Application.ViewModels;

namespace Planner.Application.Service.Queries
{
    public class GetIndispositionsQuery : IRequest<List<IndispositionViewModel>>
    {
    }
}
