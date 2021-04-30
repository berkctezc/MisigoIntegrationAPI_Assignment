using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IWholesaleCustomerDal:IEntityRepository<WholesaleCustomer>
    {
        List<WholesaleCustomerDto> GetWholesaleCustomerDetails(Expression<Func<WholesaleCustomer, bool>> filter = null);
        WholesaleCustomerDto GetWholesaleCustomerDetailsById(Expression<Func<WholesaleCustomer, bool>> filter);
    }
}