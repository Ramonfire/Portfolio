using Microsoft.EntityFrameworkCore;
using Portfolio.Project.Repositories.Interfaces;
using Potfolio.Project.Data;
using Potfolio.Project.Models;

namespace Portfolio.Project.Repositories.impl
{
    
    public class EducationRepository : IEducationRepository
    {
        private readonly ApplicationDBContext context;
        public EducationRepository(ApplicationDBContext inContext)
        {
            context = inContext;
        }
        public Task<List<Education>> GetAllAsynch()
        {
           return  context.Educations.ToListAsync();
        }
        //null is a valid return
        public Education GetById(uint id)
        {
            Education? education = context.Educations.Find(id);
            return education;
        }
    }
}
