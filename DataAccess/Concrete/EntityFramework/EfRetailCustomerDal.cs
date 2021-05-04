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
    public class EfRetailCustomerDal : EfEntityRepositoryBase<RetailCustomer, EntegrasyonDbContext>, IRetailCustomerDal
    {
        public List<RetailCustomerDto> GetRetailCustomerDetails(Expression<Func<RetailCustomer, bool>> filter = null)
        {
            using (EntegrasyonDbContext context = new EntegrasyonDbContext())
            {
                var result =
                   from retailCustomer in context.RetailCustomers
                   join postalAddress in context.PostalAddresses on retailCustomer.PostalAddressesId equals postalAddress.Id
                   join attribute in context.Attributes on retailCustomer.AttributesId equals attribute.Id
                   join communication in context.Communications on retailCustomer.CommunicationsId equals communication.Id
                   select new RetailCustomerDto
                   {
                       Id = retailCustomer.Id,
                       ModelType = retailCustomer.ModelType,
                       CurrAccCode=retailCustomer.CurrAccCode,
                       FirstName = retailCustomer.FirstName,
                       LastName = retailCustomer.LastName,
                       IdentityNum = retailCustomer.IdentityNum,
                       OfficeCode = retailCustomer.OfficeCode,
                       RetailSalePriceGroupCode = retailCustomer.RetailSalePriceGroupCode,
                       CreditLimit = retailCustomer.CreditLimit,
                       CurrencyCode = retailCustomer.CurrencyCode,
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

        public RetailCustomerDto GetRetailCustomerDetailsById(Expression<Func<RetailCustomer, bool>> filter)
        {
            using (EntegrasyonDbContext context = new EntegrasyonDbContext())
            {
                var result =
                   from retailCustomer in filter is null
                       ? context.RetailCustomers
                       : context.RetailCustomers.Where(filter)
                   join postalAddress in context.PostalAddresses on retailCustomer.PostalAddressesId equals postalAddress.Id
                   join attribute in context.Attributes on retailCustomer.AttributesId equals attribute.Id
                   join communication in context.Communications on retailCustomer.CommunicationsId equals communication.Id
                   select new RetailCustomerDto
                   {
                       Id = retailCustomer.Id,
                       CurrAccCode = retailCustomer.CurrAccCode,
                       ModelType = retailCustomer.ModelType,
                       FirstName = retailCustomer.FirstName,
                       LastName = retailCustomer.LastName,
                       IdentityNum = retailCustomer.IdentityNum,
                       OfficeCode = retailCustomer.OfficeCode,
                       RetailSalePriceGroupCode = retailCustomer.RetailSalePriceGroupCode,
                       CreditLimit = retailCustomer.CreditLimit,
                       CurrencyCode = retailCustomer.CurrencyCode,
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