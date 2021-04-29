using Core.Entities;

namespace Entities.DTOs
{
    public class WholesaleCustomerDto:IDto
    {
        public int Id { get; set; }
        public int ModelType { get; set; }
        public string CurrAccCode { get; set; }
        public string CurrAccDescription { get; set; }
        public string IdentityNum { get; set; }
        public string OfficeCode { get; set; }
        public string WholeSalePriceGroupCode { get; set; }
        public decimal CreditLimit { get; set; }
        public string CurrencyCode { get; set; }
        public int CustomerTypeCode { get; set; }
        public string TaxNumber { get; set; }
        public string TaxOfficeCode { get; set; }
        public string MersisNum { get; set; }
        //
        public int PostalAddressesId { get; set; }
        public string AdressTypeCode { get; set; }
        public string CountryCode { get; set; }
        public string StateCode { get; set; }
        public string CityCode { get; set; }
        public string DistrictCode { get; set; }
        public string Address { get; set; }
        //
        public int AttributesId { get; set; }
        public int AttributeTypeCode { get; set; }
        public string AttributeCode { get; set; }
        //
        public int CommunicationsId { get; set; }
        public string CommunicationTypeCode { get; set; }
        public string CommAddress { get; set; }
    }
}