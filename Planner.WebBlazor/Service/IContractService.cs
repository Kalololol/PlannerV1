using Planner.WebBlazor.Models;

namespace Planner.WebBlazor.Service
{
    public interface IContractService
    {
        //Task<List<AllEmployee>> GetAllEmployees();
        Task<DetailsContract> GetContractById(int id);
        Task<CreateContract> CreateContract(CreateContract contract);
        Task<EditContract> EditContract(EditContract contract);
       // Task<EditContract> DeleteContract(EditContract contract);
    }
}
