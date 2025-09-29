using Potfolio.Project.Models;

namespace Portfolio.Project.Repositories.Interfaces
{
    public interface ISkillRepository
    {
        Task<List<Skill>> GetAllAsynch();
        Skill GetById(uint skillId);
    }
}
