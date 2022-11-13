using MediatR;

namespace Planner.Application.Service.Command
{
    public class DeleteIndispositionCommand : IRequest
    {
        public int Id { get; set; }
    }
}
