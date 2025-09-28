namespace Potfolio.Project.Models
{
    public class Education(string organization, string organizationAdress, string description, string certificateLink)
    {
        public uint Id { get; set; }

        public string Organization { get;  set; } = organization;
        public string OrganizationAdress { get;  set; } = organizationAdress;
        public string Description { get;  set; } = description;
        public string CertificateLink { get;  set; } = certificateLink;

        public Education() : this(string.Empty, string.Empty, string.Empty, string.Empty) { }
    }
}
