namespace Planner.WebBlazor.Models
{
    public class EditRequest
    {
        public int Id { get; set; }
        public DateTime DayRequest { get; set; }
        public Shift Change { get; set; }
        public int EmployeeId { get; set; }

        public EditRequest(int id, DateTime dayRequest, Shift change, int employeeId)
        {
            Id = id;
            DayRequest = dayRequest;
            Change = change;
            EmployeeId = employeeId;
        }
    }
}
