namespace Planner.Application.ViewModels
{
    public class PlanDayViewModel
    {
        public int Id { get; set; }
        public DateTime DatePlanDay { get; set; }
        public string NameDay { get; set; }
        public ICollection<EmployeeViewModel> Employees { get; set; }
        public int WardId { get; set; }
    }
}
