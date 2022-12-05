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
            return await httpClient.GetJsonAsync<EditDetailsEmployee>($"api/employee/getEmployeeById/{id}");
        }

        public async Task<CreateEmployee> CreateEmployee(CreateEmployee employee)
        {
            return await httpClient.PostJsonAsync<CreateEmployee>($"api/employee/createEmployee", employee);
        }
        public async Task<EditDetailsEmployee> EditEmployee(EditDetailsEmployee employee)
        {
            return await httpClient.PostJsonAsync<EditDetailsEmployee>($"api/employee/editEmployee", employee);
        }
    }
}
