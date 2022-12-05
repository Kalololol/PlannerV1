using Planner.WebBlazor.Models;

namespace Planner.WebBlazor.Service
{
    public interface IEmployeeService
    {
        Task<List<AllEmployee>> GetAllEmployees();
        Task<EditDetailsEmployee> GetEmployeeById(int id);
        Task<CreateEmployee> CreateEmployee(CreateEmployee employee);
        Task<EditDetailsEmployee> EditEmployee(EditDetailsEmployee employee);

    }
}
