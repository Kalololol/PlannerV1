using MediatR;
using Planner.Application.ViewModels;

namespace Planner.Application.Service.Command
{
    public class CreateContractCommand : IRequest
    {
        public int DeclaredHours { get; set; }
        public ContractTypeViewModel ContractType { get; set; }
        public int EmployeeId { get; set; }

        public CreateContractCommand()
        {

        }

        public CreateContractCommand(int declaredHours, ContractTypeViewModel contractType, int employeeId)
        {
            DeclaredHours = declaredHours;
            ContractType = contractType;
            EmployeeId = employeeId;
        }
    }
}
