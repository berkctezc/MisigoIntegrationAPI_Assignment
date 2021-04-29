using Core.Entities;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class RetailCustomer:IEntity,ICustomer
    {
        public int Id { get; set; }
        public int ModelType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNum { get; set; }
        public string OfficeCode { get; set; }
        public string RetailSalePriceGroupCode { get; set; }
        public decimal CreditLimit { get; set; }
        public string CurrencyCode { get; set; }
        public int PostalAddressesId { get; set; }
        public int AttributesId { get; set; }
        public int CommunicationsId { get; set; }
    }
}
