using Planner.WebBlazor.Models;

namespace Planner.WebBlazor.Service
{
    public interface IIndispositionService
    {
        Task<List<AllIndisposition>> GetAllIndisposition();
        Task<CreateIndisposition> CreateIndisposition(CreateIndisposition indisposition);
        Task<EditIndisposition> EditIndisposition(EditIndisposition indisposition);


    }
}
