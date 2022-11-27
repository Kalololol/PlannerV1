namespace Planner.WebBlazor.Models
{
    public class DetailsRequest
    {
        public int Id { get; set; }
        public DateTime DayRequest { get; set; }
        public Shift Change { get; set; }
        public int EmployeeId { get; set; }

        public DetailsRequest()
        {
        }
    }
}
