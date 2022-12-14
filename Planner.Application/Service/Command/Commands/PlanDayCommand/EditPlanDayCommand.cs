using MediatR;
using Planner.Application.ViewModels;

namespace Planner.Application.Service.Command
{
    public class EditPlanDayCommand : IRequest
    {
        public int Id { get; set; }
        public DateTime DatePlanDay { get; set; }
        public string NameDay { get; set; }
        public ICollection<EmployeeViewModel> Employees { get; set; }
    }
}
