namespace Potfolio.Project.Models
{
    public enum MasteryLevel
    {
        None,
        casual,
        Professional,
        Native
    }

    public class MasteredLanguage(string language, MasteryLevel level)
    {
        public uint Id { get; set; }
        public string Language { get;  set; } = language;
        public MasteryLevel Level { get;  set; } = level;

        public MasteredLanguage() : this(string.Empty,   MasteryLevel.None) { }
    }
}
