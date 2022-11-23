using MediatR;

namespace Planner.Application.Service.Command
{
    public class CreateRequestCommand : IRequest
    {
        public DateTime DayRequest { get; set; }
        public string Change { get; set; }
        public int EmployeeId { get; set; }
    }
}
