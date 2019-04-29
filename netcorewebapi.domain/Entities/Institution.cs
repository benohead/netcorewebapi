using System;

namespace netcorewebapi.domain.Entities
{
    public class Institution : BaseEntity
    {
        public Institution()
        {
        }

        public string InstitutionName { get; set; }
        public string InstitutionPhone { get; set; }
        public string InstitutionAddressLine1 { get; set; }
        public string InstitutionAddressLine2 { get; set; }
        public string InstitutionZipCode { get; set; }
        public string InstitutionCity { get; set; }
        public string InstitutionState { get; set; }
        public string InstitutionCountry { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}