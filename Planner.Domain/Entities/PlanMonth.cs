using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Domain.Entities
{
    public class PlanMonth : Entity
    {
        public DateTime DateMonth { get; set; }
        public string DateMonthBy { get; set; }
        public ICollection<PlanDay> PlanDays { get; set; }
        public Ward Ward { get; set; }
        public int WardId { get; set; }
    }
}
