
namespace Web_Service.Models
{
    public class MoscowEducationalInstitutionInfo
    {
        public int Id { get; set; }

        public string ShortName { get; set; }
        public string FullName { get; set; }

        public System.Collections.Generic.List<LicensingAndAccreditation> LicensingAndAccreditation { get; set; } = new System.Collections.Generic.List<LicensingAndAccreditation>();
        public System.Collections.Generic.List<InstitutionsAddresses> InstitutionsAddresses { get; set; } = new System.Collections.Generic.List<InstitutionsAddresses>();

        public string LegalOrganization { get; set; }
        public string Subordination { get; set; }
        public string ChiefName { get; set; }
        public string LegalAddress { get; set; }
        public string WebSite { get; set; }
        public string OrgType { get; set; }
    }
}