using Core.Entities;

namespace Entities.Types
{
    public class PostalAddress:IEntity
    {
        public int Id { get; set; }
        public string AdressTypeCode { get; set; }
        public string CountryCode { get; set; }
        public string StateCode { get; set; }
        public string CityCode { get; set; }
        public string DistrictCode { get; set; }
        public string Address { get; set; }
    }
}