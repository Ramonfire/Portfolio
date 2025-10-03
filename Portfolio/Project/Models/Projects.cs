namespace Potfolio.Project.Models
{
    public class Projects(string name, string link,string learning)
    {
        public uint Id { get; set; }
        public string Name { get;  set; } = name;
        public string Link { get;  set; } = link;

        public bool IsHighLight { get; set; } = false;
        public Projects() : this(string.Empty, string.Empty,string.Empty) { }
    }
}
