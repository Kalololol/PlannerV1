using MediatR;

namespace Planner.Application.Service.Command.Commands.RequestCommand
{
    public class EditRequestCommand : IRequest
    {
        public int Id { get; set; }
        public DateTime DayRequest { get; set; }
        public string Change { get; set; }
        
    }
}
