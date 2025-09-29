using Potfolio.Project.Models;

namespace Portfolio.Project.Repositories.Interfaces
{
    public interface IWorkExperienceRepository
    {
        Task<List<WorkExperience>> GetAllAsynch();
        WorkExperience GetById(uint id);
    }
}
