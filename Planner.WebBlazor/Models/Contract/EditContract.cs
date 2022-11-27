﻿namespace Planner.WebBlazor.Models
{
    public class EditContract
    {
        public int Id { get; set; }
        public int DeclaredHours { get; set; }
        //public int ContractTypeId { get; set; }
        public ContractType ContractType { get; set; }
        public int EmployeeId { get; set; }

        public EditContract()
        {
                
        }
        public EditContract(int id, int declaredHours, ContractType contractType, int employeeId)
        {
            Id = id;
            DeclaredHours = declaredHours;
            ContractType = contractType;
            EmployeeId = employeeId;
        }
    }
}
