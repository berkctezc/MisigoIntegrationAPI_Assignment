using Core.Entities;

namespace Entities.Abstract
{
    public interface ICustomer:IEntity
    {
        public int Id { get; set; }
        public int ModelType { get; set; }
        public string IdentityNum { get; set; }
        public string OfficeCode { get; set; }
        public decimal CreditLimit { get; set; }
        public string CurrencyCode { get; set; }
        public int PostalAddressesId { get; set; }
        public int AttributesId { get; set; }
        public int CommunicationsId { get; set; }
    }
}
