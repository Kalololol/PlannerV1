namespace Planner.WebBlazor.Models
{
    public class CreateRequest
    {
        public DateTime DayRequest { get; set; }
        public Shift Change { get; set; }
        public int EmployeeId { get; set; }
        public CreateRequest()
        {
        }

        public CreateRequest(DateTime dayRequest, Shift change, int employeeId)
        {
            DayRequest = dayRequest;
            Change = change;
            EmployeeId = employeeId;
        }
    }
}
