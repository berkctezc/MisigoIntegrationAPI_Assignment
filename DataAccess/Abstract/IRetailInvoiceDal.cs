using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IRetailInvoiceDal:IEntityRepository<RetailInvoice>
    {
        List<RetailInvoiceDto> GetRetailInvoiceDetails(Expression<Func<RetailInvoice, bool>> filter = null);
        RetailInvoiceDto GetRetailInvoiceDetailsById(Expression<Func<RetailInvoice, bool>> filter = null);
    }
}