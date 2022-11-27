using MediatR;
using Planner.Application.ViewModels;

namespace Planner.Application.Service.Command
{
    public class EditContractCommand : IRequest
    {
        public int Id { get; set; }
        public int DeclaredHours { get; set; }
        public ContractTypeViewModel ContractType { get; set; }
        public int EmployeeId { get; set; }

        public EditContractCommand()
        {

        }

        public EditContractCommand(int id, int declaredHours, ContractTypeViewModel contractType, int employeeId)
        {
            Id = id;
            DeclaredHours = declaredHours;
            ContractType = contractType;
            EmployeeId = employeeId;
        }
    }
}
