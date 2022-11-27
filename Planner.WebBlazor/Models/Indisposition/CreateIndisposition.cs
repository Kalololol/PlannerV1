namespace Planner.WebBlazor.Models
{
    public class CreateIndisposition
    {
        public int Id { get; set; }
        public DateTime DayIndisposition { get; set; }
        public Shift Change { get; set; }
        public int EmployeeId { get; set; }

        public CreateIndisposition(){}

        public CreateIndisposition(int id, DateTime dayIndisposition, Shift change, int employeeId)
        {
            Id = id;
            DayIndisposition = dayIndisposition;
            Change = change;
            EmployeeId = employeeId;
        }
    }
}
