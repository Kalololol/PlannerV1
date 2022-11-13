using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Domain.Entities
{
    public class PlanDay : Entity
    {
        public DateTime DatePlanDay { get; set; }
        public string NameDay { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public Ward Ward { get; set; }
        public int WardId { get; set; }
    }
}
