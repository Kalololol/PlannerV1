using Microsoft.AspNetCore.Components;

using Planner.WebBlazor.Models;


namespace Planner.WebBlazor.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<AllEmployee>> GetAllEmployees()
        {
            return await httpClient.GetJsonAsync<List<AllEmployee>>("api/employee/getEmployees");
        }

        public async Task<EditDetailsEmployee> GetEmployeeById(int id)
        {
            string send = "api/employee/getEmployeeById" + $"/{id}";
            return await httpClient.GetJsonAsync<EditDetailsEmployee>(send);
        }


    }
}
