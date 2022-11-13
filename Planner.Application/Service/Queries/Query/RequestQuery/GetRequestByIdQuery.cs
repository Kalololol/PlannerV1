using MediatR;
using Planner.Application.ViewModels;

namespace Planner.Application.Service.Queries
{
    public class GetRequestByIdQuery : IRequest<RequestViewModel>
    {
        public int Id { get; set; }
    }
}
