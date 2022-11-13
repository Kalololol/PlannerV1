using MediatR;

namespace Planner.Application.Service.Command
{
    public class DeletePlanDayCommand : IRequest
    {
        public int Id { get; set; }
    }
}
