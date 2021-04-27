using System.Collections.Generic;
using Core.Entities;
using Entities.Abstract;
using Entities.Types;

namespace Entities.Concrete
{
    public class WholesaleCustomer:IEntity, ICustomer
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
        public List<PostalAddress> PostalAddresses { get; set; }
        public List<Attribute> Attributes { get; set; }
        public List<Communication> Communications { get; set; }
    }
}
