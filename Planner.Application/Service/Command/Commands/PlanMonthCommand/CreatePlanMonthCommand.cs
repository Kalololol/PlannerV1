using MediatR;
using Planner.Application.ViewModels;

namespace Planner.Application.Service.Command
{
    public class CreatePlanMonthCommand : IRequest
    {
        public DateTime DateMonth { get; set; }
        public string DateMonthBy { get; set; }
        public ICollection<PlanDayViewModel> PlanDays { get; set; }
    }
}
