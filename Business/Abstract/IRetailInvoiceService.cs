using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRetailInvoiceService
    {
        IResult Add(RetailInvoice retailInvoice);
        IResult Delete(RetailInvoice retailInvoice);
        IResult Update(RetailInvoice retailInvoice);
        IDataResult<List<RetailInvoice>> GetAll();
        IDataResult<RetailInvoice> GetById(int id);
    }
}