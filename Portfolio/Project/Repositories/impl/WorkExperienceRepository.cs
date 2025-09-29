using Microsoft.EntityFrameworkCore;
using Portfolio.Project.Repositories.Interfaces;
using Potfolio.Project.Data;
using Potfolio.Project.Models;

namespace Portfolio.Project.Repositories.impl
{
    public class WorkExperienceRepository : IWorkExperienceRepository
    {
        private readonly ApplicationDBContext context;
        public WorkExperienceRepository(ApplicationDBContext inContext)
        {
            context = inContext;
        }
        public Task<List<WorkExperience>> GetAllAsynch()
        {
           return context.WorkExperiences.ToListAsync();
        }
        //null is a valid return
        public WorkExperience GetById(uint id)
        {
            return context.WorkExperiences.Find(id);
        }
    }
}
