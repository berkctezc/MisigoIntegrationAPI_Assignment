using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IRetailOrderDal:IEntityRepository<RetailOrder>
    {
        List<RetailOrderDto> GetRetailOrderDetails(Expression<Func<RetailOrder, bool>> filter = null);
        RetailOrderDto GetRetailOrderDetailsById(Expression<Func<RetailOrder, bool>> filter = null);
    }
}