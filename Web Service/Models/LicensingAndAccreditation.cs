

namespace Web_Service.Models
{
    public class LicensingAndAccreditation
    {
        public int Id { get; set; }

        public string LicenseAvailability { get; set; }
        public string LicenseSeries { get; set; }
        public string LicenseNumber { get; set; }
        public string LicenseExpires { get; set; }
        public string AccreditationAvailability { get; set; }
        public string AccreditationSeries { get; set; }
        public string AccreditationNumber { get; set; }
        public string AccreditationExpires { get; set; }

        public System.Collections.Generic.List<MoscowEducationalInstitutionInfo> MoscowEducationalInstitutionInfo { get; set; } = new System.Collections.Generic.List<MoscowEducationalInstitutionInfo>();
    }
}
