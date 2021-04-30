using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IRetailCustomerDal : IEntityRepository<RetailCustomer>
    {
        List<RetailCustomerDto> GetRetailCustomerDetails(Expression<Func<RetailCustomer, bool>> filter = null);
        RetailCustomerDto GetRetailCustomerDetailsById(Expression<Func<RetailCustomer, bool>> filter);
    }
}