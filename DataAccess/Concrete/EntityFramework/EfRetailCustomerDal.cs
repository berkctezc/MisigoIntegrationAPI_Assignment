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
                   from retailCustomer in filter is null
                       ? context.RetailCustomers
                       : context.RetailCustomers.Where(filter)
                   join postalAdress in context.PostalAddresses on retailCustomer.PostalAddressesId equals postalAdress.Id
                   join attribute in context.Attributes on retailCustomer.AttributesId equals attribute.Id
                   join communication in context.Communications on retailCustomer.CommunicationsId equals communication.Id
                   select new RetailCustomerDto
                   {
                       Id = retailCustomer.Id,
                       ModelType = retailCustomer.ModelType,
                       FirstName = retailCustomer.FirstName,
                       LastName = retailCustomer.LastName,
                       IdentityNum = retailCustomer.IdentityNum,
                       OfficeCode = retailCustomer.OfficeCode,
                       RetailSalePriceGroupCode = retailCustomer.RetailSalePriceGroupCode,
                       CreditLimit = retailCustomer.CreditLimit,
                       CurrencyCode = retailCustomer.CurrencyCode,
                       //
                       PostalAddressesId = postalAdress.Id,
                       AdressTypeCode = postalAdress.AdressTypeCode,
                       CountryCode = postalAdress.CountryCode,
                       StateCode = postalAdress.StateCode,
                       CityCode = postalAdress.CityCode,
                       DistrictCode = postalAdress.DistrictCode,
                       Address = postalAdress.Address,
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
    }
}