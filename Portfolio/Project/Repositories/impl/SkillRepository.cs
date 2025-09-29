using Microsoft.EntityFrameworkCore;
using Portfolio.Project.Repositories.Interfaces;
using Potfolio.Project.Data;
using Potfolio.Project.Models;

namespace Portfolio.Project.Repositories.impl
{
    public class SkillRepository : ISkillRepository
    {
        private readonly ApplicationDBContext context;
        public SkillRepository(ApplicationDBContext inContext)
        {
            context = inContext;
        }
        public Task<List<Skill>> GetAllAsynch()
        {
            return context.Skills
                        .Include(s => s.Category)
                        .ToListAsync();
        }
        //null is a valid return
        public Skill GetById(uint skillId)
        {
            return context.Skills.Include(s => s.Category).FirstOrDefault(s => s.Id == skillId);
        }
    }
}
