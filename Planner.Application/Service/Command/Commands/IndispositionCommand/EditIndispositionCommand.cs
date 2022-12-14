using MediatR;

namespace Planner.Application.Service.Command
{
    public class EditIndispositionCommand : IRequest
    {
        public int Id { get; set; }
        public DateTime DayIndisposition { get; set; }
        public string Change { get; set; }
        public int EmployeeId { get; set; }
    }
}
