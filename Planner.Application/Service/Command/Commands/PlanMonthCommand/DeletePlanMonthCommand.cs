using MediatR;

namespace Planner.Application.Service.Command
{
    public class DeletePlanMonthCommand : IRequest
    {
        public int Id { get; set; }
    }
}
