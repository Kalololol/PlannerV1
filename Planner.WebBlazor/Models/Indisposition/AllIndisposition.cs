namespace Planner.WebBlazor.Models
{
    public class AllIndisposition
    {
        public int Id { get; set; }
        public DateTime DayIndisposition { get; set; }
        public Shift Change { get; set; }
        public int EmployeeId { get; set; }

        public AllIndisposition() {}


    }
}
