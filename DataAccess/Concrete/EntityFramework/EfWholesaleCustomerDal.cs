using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfWholesaleCustomerDal : EfEntityRepositoryBase<WholesaleCustomer, EntegrasyonDbContext>, IWholesaleCustomerDal
    {
        public List<WholesaleCustomerDto> GetWholesaleCustomerDetails(Expression<Func<WholesaleCustomer, bool>> filter = null)
        {
            using (EntegrasyonDbContext context = new EntegrasyonDbContext())
            {
                var result =
                   from wholesaleCustomer in filter is null
                       ? context.WholesaleCustomers
                       : context.WholesaleCustomers.Where(filter)
                   join postalAddress in context.PostalAddresses on wholesaleCustomer.PostalAddressesId equals postalAddress.Id
                   join attribute in context.Attributes on wholesaleCustomer.AttributesId equals attribute.Id
                   join communication in context.Communications on wholesaleCustomer.CommunicationsId equals communication.Id
                   select new WholesaleCustomerDto
                   {
                       Id = wholesaleCustomer.Id,
                       ModelType = wholesaleCustomer.ModelType,
                       CurrAccCode = wholesaleCustomer.CurrAccCode,
                       CurrAccDescription = wholesaleCustomer.CurrAccDescription,
                       IdentityNum = wholesaleCustomer.IdentityNum,
                       OfficeCode = wholesaleCustomer.OfficeCode,
                       WholeSalePriceGroupCode = wholesaleCustomer.WholeSalePriceGroupCode,
                       CreditLimit = wholesaleCustomer.CreditLimit,
                       CurrencyCode = wholesaleCustomer.CurrencyCode,
                       CustomerTypeCode = wholesaleCustomer.CustomerTypeCode,
                       TaxNumber = wholesaleCustomer.TaxNumber,
                       TaxOfficeCode = wholesaleCustomer.TaxOfficeCode,
                       MersisNum = wholesaleCustomer.MersisNum,
                       //
                       PostalAddressesId = postalAddress.Id,
                       AddressTypeCode = postalAddress.AddressTypeCode,
                       CountryCode = postalAddress.CountryCode,
                       StateCode = postalAddress.StateCode,
                       CityCode = postalAddress.CityCode,
                       DistrictCode = postalAddress.DistrictCode,
                       Address = postalAddress.Address,
                       //
                       AttributesId = attribute.Id,
                       AttributeTypeCode = attribute.AttributeTypeCode,
                       AttributeCode = attribute.AttributeCode,
                       //
                       CommunicationsId = communication.Id,
                       CommunicationTypeCode = communication.CommunicationTypeCode,
                       CommAddress = communication.CommAddress
                   };
                return result.ToList();
            }
        }

        public WholesaleCustomerDto GetWholesaleCustomerDetailsById(Expression<Func<WholesaleCustomer, bool>> filter)
        {
            using (EntegrasyonDbContext context = new EntegrasyonDbContext())
            {
                var result =
                   from wholesaleCustomer in filter is null
                       ? context.WholesaleCustomers
                       : context.WholesaleCustomers.Where(filter)
                   join postalAddress in context.PostalAddresses on wholesaleCustomer.PostalAddressesId equals postalAddress.Id
                   join attribute in context.Attributes on wholesaleCustomer.AttributesId equals attribute.Id
                   join communication in context.Communications on wholesaleCustomer.CommunicationsId equals communication.Id
                   select new WholesaleCustomerDto
                   {
                       Id = wholesaleCustomer.Id,
                       ModelType = wholesaleCustomer.ModelType,
                       CurrAccCode = wholesaleCustomer.CurrAccCode,
                       CurrAccDescription = wholesaleCustomer.CurrAccDescription,
                       IdentityNum = wholesaleCustomer.IdentityNum,
                       OfficeCode = wholesaleCustomer.OfficeCode,
                       WholeSalePriceGroupCode = wholesaleCustomer.WholeSalePriceGroupCode,
                       CreditLimit = wholesaleCustomer.CreditLimit,
                       CurrencyCode = wholesaleCustomer.CurrencyCode,
                       CustomerTypeCode = wholesaleCustomer.CustomerTypeCode,
                       TaxNumber = wholesaleCustomer.TaxNumber,
                       TaxOfficeCode = wholesaleCustomer.TaxOfficeCode,
                       MersisNum = wholesaleCustomer.MersisNum,
                       //
                       PostalAddressesId = postalAddress.Id,
                       AddressTypeCode = postalAddress.AddressTypeCode,
                       CountryCode = postalAddress.CountryCode,
                       StateCode = postalAddress.StateCode,
                       CityCode = postalAddress.CityCode,
                       DistrictCode = postalAddress.DistrictCode,
                       Address = postalAddress.Address,
                       //
                       AttributesId = attribute.Id,
                       AttributeTypeCode = attribute.AttributeTypeCode,
                       AttributeCode = attribute.AttributeCode,
                       //
                       CommunicationsId = communication.Id,
                       CommunicationTypeCode = communication.CommunicationTypeCode,
                       CommAddress = communication.CommAddress
                   };
                return result.SingleOrDefault();
            }
        }
    }
}