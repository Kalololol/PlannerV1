using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Domain.Entities
{
    public class Contract : Entity
    {
        public int DeclaredHours { get; set; }
        public ContractType ContractType { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
