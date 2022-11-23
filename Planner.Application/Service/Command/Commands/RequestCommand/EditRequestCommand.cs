using MediatR;

namespace Planner.Application.Service.Command
{
    public class EditRequestCommand : IRequest
    {
        public int Id { get; set; }
        public DateTime DayRequest { get; set; }
        public string Change { get; set; }
        
    }
}
