

namespace Web_Service.Models
{
    public class InstitutionsAddresses
    {
        public int Id { get; set; }

        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }

        public System.Collections.Generic.List<MoscowEducationalInstitutionInfo> MoscowEducationalInstitutionInfo { get; set; } = new System.Collections.Generic.List<MoscowEducationalInstitutionInfo>();
    }
}
