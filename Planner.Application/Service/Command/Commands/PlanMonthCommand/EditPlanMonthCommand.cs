using MediatR;
using Planner.Application.ViewModels;

namespace Planner.Application.Service.Command
{
    public class EditPlanMonthCommand : IRequest
    {
        public int Id { get; set; }
        public DateTime DateMonth { get; set; }
        public string DateMonthBy { get; set; }
        public ICollection<PlanDayViewModel> PlanDays { get; set; }
    }
}
