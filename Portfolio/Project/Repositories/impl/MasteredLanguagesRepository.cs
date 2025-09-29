using Microsoft.EntityFrameworkCore;
using Portfolio.Project.Repositories.Interfaces;
using Potfolio.Project.Data;
using Potfolio.Project.Models;

namespace Portfolio.Project.Repositories.impl
{
    public class MasteredLanguagesRepository : IMasteredLanguageRepository
    {
        private readonly ApplicationDBContext context;
        public MasteredLanguagesRepository(ApplicationDBContext inContext)
        {
            context = inContext;
        }
        public Task<List<MasteredLanguage>> GetAllAsynch()
        {
           return context.MasteredLanguages.ToListAsync();
        }
        //null is a valid return
        public MasteredLanguage GetById(uint id)
        {
            return context.MasteredLanguages.Find(id);
        }
    }
}
