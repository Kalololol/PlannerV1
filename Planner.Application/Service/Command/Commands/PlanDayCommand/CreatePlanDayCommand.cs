using MediatR;
using Planner.Application.ViewModels;

namespace Planner.Application.Service.Command
{
    public class CreatePlanDayCommand : IRequest
    {
        public DateTime DatePlanDay { get; set; }
        public string NameDay { get; set; }
        public ICollection<EmployeeViewModel> Employees { get; set; }
        public CreatePlanDayCommand()
        {

        }

        public CreatePlanDayCommand(DateTime datePlanDay, string nameDay, ICollection<EmployeeViewModel> employees)
        {
            DatePlanDay = datePlanDay;
            NameDay = nameDay;
            Employees = employees;
        }
    }
}
