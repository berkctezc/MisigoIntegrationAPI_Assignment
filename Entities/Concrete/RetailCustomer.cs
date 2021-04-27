using System.Collections.Generic;
using Core.Entities;
using Entities.Abstract;
using Entities.Types;

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
        public List<PostalAddress> PostalAddresses { get; set; }
        public List<Attribute> Attributes { get; set; }
        public List<Communication> Communications { get; set; }
    }
}
