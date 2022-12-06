using Microsoft.AspNetCore.Components;
using Planner.WebBlazor.Models;

namespace Planner.WebBlazor.Service
{
    public class ContractService : IContractService
    {
        private readonly HttpClient httpClient;

        public ContractService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<DetailsContract> GetContractById(int id)
        {
            return await httpClient.GetJsonAsync<DetailsContract>($"api/contract/getContractById/{id}");
        }
        public async Task<CreateContract> CreateContract(CreateContract contract)
        {
            return await httpClient.PostJsonAsync<CreateContract>($"api/contract/createContract", contract);

        }
        public async Task<EditContract> EditContract(EditContract contract)
        {
            return await httpClient.PostJsonAsync<EditContract>($"api/contract/editContract", contract);

        }
     /*   public async Task<EditContract> DeleteContract(EditContract contract)
        {

        }*/
    }
}
