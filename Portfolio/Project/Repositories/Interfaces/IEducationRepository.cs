using Potfolio.Project.Models;

namespace Portfolio.Project.Repositories.Interfaces
{
    public interface IEducationRepository
    {
        Task<List<Education>> GetAllAsynch();
        Education GetById(uint id);
    }
}
