namespace Planner.Application.ViewModels
{
    public class PlanMonthViewModel
    {
        public int Id { get; set; }
        public DateTime DateMonth { get; set; }
        public string DateMonthBy { get; set; }
        public ICollection<PlanDayViewModel> PlanDays { get; set; }
        public int WardId { get; set; }
    }
}
