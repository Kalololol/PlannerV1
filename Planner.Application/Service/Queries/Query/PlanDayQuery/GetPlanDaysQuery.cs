using MediatR;
using Planner.Application.ViewModels;

namespace Planner.Application.Service.Queries
{
    public class GetPlanDaysQuery : IRequest<List<PlanDayViewModel>>
    {
    }
}
