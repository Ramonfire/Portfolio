namespace Potfolio.Project.Models
{
    public class SkillCategory(string categoryName)
    {
        public uint Id { get; set; }
        public string CategoryName { get;  set; } = categoryName;

        public SkillCategory() : this(string.Empty) { }
    }
}
