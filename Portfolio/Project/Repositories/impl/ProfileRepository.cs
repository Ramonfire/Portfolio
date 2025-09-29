using Microsoft.EntityFrameworkCore;
using Portfolio.Project.Repositories.Interfaces;
using Potfolio.Project.Data;
using Potfolio.Project.Models;

namespace Portfolio.Project.Repositories.impl
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly ApplicationDBContext context;
        public ProfileRepository(ApplicationDBContext inContext)
        {
            context = inContext;
        }
        public Task<List<Profile>> GetAllAsynch()
        {
            return context.Profiles.ToListAsync();
        }
        //null is a valid return
        public Profile GetById(uint id)
        {
            return context.Profiles.Find(id);
        }
    }
}
