using Core.Entities;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class WholesaleCustomer : IEntity, ICustomer
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
        public int PostalAddressesId { get; set; }
        public int AttributesId { get; set; }
        public int CommunicationsId { get; set; }
    }
}