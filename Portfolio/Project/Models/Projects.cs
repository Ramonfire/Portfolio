namespace Potfolio.Project.Models
{
    public class Projects(string name, string link)
    {
        public uint Id { get; set; }
        public string Name { get;  set; } = name;
        public string Link { get;  set; } = link;

        public Projects() : this(string.Empty, string.Empty) { }
    }
}
