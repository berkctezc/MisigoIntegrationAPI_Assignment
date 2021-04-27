using System.Collections.Generic;
using Core.Entities;
using Entities.Types;

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
        public List<PostalAddress> PostalAddresses { get; set; }
        public List<Types.Attribute> Attributes { get; set; }
        public List<Communication> Communications { get; set; }
    }
}
