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
        public async Task<EditIndisposition> GetIndispositionById(int id)
        {
            return await httpClient.GetJsonAsync<EditIndisposition>($"api/indisposition/getIndispositionById/{id}");
        }
        public async Task<CreateIndisposition> CreateIndisposition(CreateIndisposition indisposition)
        {
            return await httpClient.PostJsonAsync<CreateIndisposition>($"api/indisposition/createIndisposition", indisposition);
        }
        public async Task<EditIndisposition> EditIndisposition (EditIndisposition indisposition)
        {
            return await httpClient.PostJsonAsync<EditIndisposition>($"api/indisposition/editIndisposition", indisposition);
        }
        // Task<EditContract> DeleteContract(EditContract contract);
    }
}
