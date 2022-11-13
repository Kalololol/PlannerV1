using MediatR;

namespace Planner.Application.Service.Command
{
    public class DeleteEmployeeCommand : IRequest
    {
        public int Id { get; set; }
    }
}
