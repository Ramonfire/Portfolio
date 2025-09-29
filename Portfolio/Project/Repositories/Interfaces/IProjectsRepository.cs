using Potfolio.Project.Models;

namespace Portfolio.Project.Repositories.Interfaces
{
    public interface IProjectsRepository
    {
        Task<List<Projects>> GetAllAsynch();
        Projects GetById(uint id);
    }
}
