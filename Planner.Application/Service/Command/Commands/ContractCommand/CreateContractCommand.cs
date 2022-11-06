using MediatR;

namespace Planner.Application.Service.Command
{
    public class CreateContractCommand : IRequest
    {
        public int DeclaredHours { get; set; }
       // public ContractType ContractType { get; set; }
       // public int EmployeeId { get; set; }
    }
}
