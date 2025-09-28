namespace Potfolio.Project.Models
{
    public class Skill(string skillName, SkillCategory category)
    {
        public uint Id { get; set; }
        public string SkillName { get;  set; } = skillName;
        public SkillCategory Category { get;  set; } = category;

        public Skill() : this(string.Empty, null!) { }
    }
}
