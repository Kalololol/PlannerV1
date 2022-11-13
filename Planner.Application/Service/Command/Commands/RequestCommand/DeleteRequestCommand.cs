using MediatR;

namespace Planner.Application.Service.Command.Commands.RequestCommand
{
    public class DeleteRequestCommand : IRequest
    {
        public int Id { get; set; }
    }
}
