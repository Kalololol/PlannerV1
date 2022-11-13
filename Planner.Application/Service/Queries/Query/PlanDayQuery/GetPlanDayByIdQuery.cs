using MediatR;
using Planner.Application.ViewModels;

namespace Planner.Application.Service.Queries
{
    public class GetPlanDayByIdQuery : IRequest<PlanDayViewModel>
    {
        public int Id { get; set; }
    }
}
