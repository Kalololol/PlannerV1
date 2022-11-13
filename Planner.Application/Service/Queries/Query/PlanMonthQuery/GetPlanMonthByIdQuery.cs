using MediatR;
using Planner.Application.ViewModels;

namespace Planner.Application.Service.Queries
{
    public class GetPlanMonthByIdQuery : IRequest<PlanMonthViewModel>
    {
        public int Id { get; set; }
    }
}
