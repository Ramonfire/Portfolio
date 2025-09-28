using Microsoft.EntityFrameworkCore;
using Potfolio.Project.Models;
using System.Reflection.Emit;

namespace Potfolio.Project.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<SkillCategory> SkillCategories { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<MasteredLanguage> MasteredLanguages { get; set; }
      
    }  

    
}
