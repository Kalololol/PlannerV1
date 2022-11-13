using MediatR;
using Planner.Application.ViewModels;

namespace Planner.Application.Service.Queries
{
    public class GetWardByIdQuery : IRequest <WardViewModel> 
    {
        public int Id { get; set; }
    }
}
