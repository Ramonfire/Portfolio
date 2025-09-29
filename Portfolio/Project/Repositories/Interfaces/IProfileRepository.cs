using Potfolio.Project.Models;

namespace Portfolio.Project.Repositories.Interfaces
{
    public interface IProfileRepository
    {
         Task<List<Profile>> GetAllAsynch();
        Profile GetById(uint id);
    }
}
