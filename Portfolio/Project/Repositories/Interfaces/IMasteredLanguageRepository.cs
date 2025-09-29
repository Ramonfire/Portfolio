using Potfolio.Project.Models;

namespace Portfolio.Project.Repositories.Interfaces
{
    public interface IMasteredLanguageRepository
    {
        Task<List<MasteredLanguage>> GetAllAsynch();
        MasteredLanguage GetById(uint id);
    }
}
