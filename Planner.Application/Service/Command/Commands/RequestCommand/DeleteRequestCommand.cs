using MediatR;

namespace Planner.Application.Service.Command
{
    public class DeleteRequestCommand : IRequest
    {
        public int Id { get; set; }
    }
}
