namespace Potfolio.Project.Models
{
    public class WorkExperience(string title, string companyName, DateOnly startDate, DateOnly? endDate, string description)
    {
        public uint Id { get; set; }
        public string Title { get;  set; } = title;
        public string CompanyName { get;  set; } = companyName;
        public DateOnly StartDate { get;  set; } = startDate;
        public DateOnly? EndDate { get;  set; } = endDate;
        public string Description { get;  set; } = description;

        public WorkExperience() : this(string.Empty, string.Empty, default, null, string.Empty) { }
    }
}
