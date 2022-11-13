using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Domain.Entities
{
    public class Indisposition : Entity
    {
        public DateTime DayIndisposition { get; set; }
        public Shift Change { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}
