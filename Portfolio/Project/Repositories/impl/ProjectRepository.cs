using Microsoft.EntityFrameworkCore;
using Portfolio.Project.Repositories.Interfaces;
using Potfolio.Project.Data;
using Potfolio.Project.Models;

namespace Portfolio.Project.Repositories.impl
{
    public class ProjectRepository : IProjectsRepository
    {
        private readonly ApplicationDBContext context;
        public ProjectRepository(ApplicationDBContext inContext)
        {
            context = inContext;
        }
        public Task<List<Projects>> GetAllAsynch()
        {
            return context.Projects.ToListAsync();
        }
        //null is a valid return
        public Projects GetById(uint id)
        {
            return context.Projects.Find(id);
        }
    }
}
