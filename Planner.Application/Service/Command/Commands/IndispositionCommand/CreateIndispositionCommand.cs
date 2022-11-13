using MediatR;

namespace Planner.Application.Service.Command
{
    public class CreateIndispositionCommand : IRequest
    {
        public DateTime DayIndisposition { get; set; }
        public string Change { get; set; }
        public int EmployeeId { get; set; }

        public CreateIndispositionCommand()
        {

        }
        public CreateIndispositionCommand(DateTime dayIndisposition, string change, int employeeId)
        {
            DayIndisposition = dayIndisposition;
            Change = change;
            EmployeeId = employeeId;
        }
    }
}
