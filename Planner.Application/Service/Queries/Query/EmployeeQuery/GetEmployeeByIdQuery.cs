using MediatR;
using Planner.Application.ViewModels;

namespace Planner.Application.Service.Queries
{
    public class GetEmployeeByIdQuery : IRequest<EmployeeViewModel>
    {
        public int Id { get; set; }

        public GetEmployeeByIdQuery()
        {

        }
        public GetEmployeeByIdQuery(int id)
        {
            Id = id;
        }
    }
}
