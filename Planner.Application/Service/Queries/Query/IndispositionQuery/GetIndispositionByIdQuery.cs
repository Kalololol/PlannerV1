using MediatR;
using Planner.Application.ViewModels;

namespace Planner.Application.Service.Queries
{
    public class GetIndispositionByIdQuery : IRequest <IndispositionViewModel>
    {
        public int Id { get; set; }

        public GetIndispositionByIdQuery(int id)
        {
            Id = id;
        }
    }
}
