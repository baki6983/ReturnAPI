using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressAPI.Models
{
    public class Customer
    {
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FirstName { get; set; }
        public string PersonTitle { get; set; }
        public string Gender { get; set; }
        public string CareOfName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string PostCode { get; set; }
        public string CityName { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string CustomerType { get; set; }
        public string IkeaFamilyNumber { get; set; }
        public string TaxRegNo { get; set; }
        public string TaxIdType { get; set; }
        public string OrganisationNumber { get; set; }
        public string PassportNumber { get; set; }
        public string TelephoneHome { get; set; }
        public string TelephoneWork { get; set; }
        public string TelephoneMobile { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string IdentityType { get; set; }
        public string IdentityNumber { get; set; }
        public string PreferedLanguage { get; set; }
        public string ContactType { get; set; }
    }
}
