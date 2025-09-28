namespace Potfolio.Project.Models
{
    public class Profile(string name, string aboutme, string email, string gitHub, string linkedIn, DateOnly birthDay)
    {
        public uint Id { get; set; }

        public string Name { get;  set; } = name;
        public string Aboutme { get;  set; } = aboutme;
        public string Email { get;  set; } = email;
        public string GitHub { get;  set; } = gitHub;
        public string LinkedIn { get;  set; } = linkedIn;
        public DateOnly BirthDay { get;  set; } = birthDay;

        public Profile() : this(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, DateOnly.MinValue) { }
    }
}
