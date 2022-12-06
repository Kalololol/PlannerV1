using Microsoft.AspNetCore.Components;
using Planner.WebBlazor.Models;

namespace Planner.WebBlazor.Service
{
    public class IndispositionService : IIndispositionService
    {
        private readonly HttpClient httpClient;

        public IndispositionService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<AllIndisposition>> GetAllIndisposition()
        {
            return await httpClient.GetJsonAsync<List<AllIndisposition>>($"api/indisposition/getAllIndispositions");
        }
        //Task<DetailsContract> GetContractById(int id);
        public async Task<CreateIndisposition> CreateIndisposition(CreateIndisposition indisposition)
        {

        }
        public async Task<EditIndisposition> EditIndisposition (EditIndisposition indisposition)
        {
            
        }
        // Task<EditContract> DeleteContract(EditContract contract);
    }
}
