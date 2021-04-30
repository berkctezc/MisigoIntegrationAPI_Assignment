using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Abstract;

namespace Business.Abstract
{
    public interface IWholesaleInvoiceService
    {
        IResult Add(IInvoice invoice);
        IResult Delete(IInvoice invoice);
        IResult Update(IInvoice invoice);
        IDataResult<List<IInvoice>> GetAll();
        IDataResult<IInvoice> GetById(int id);
    }
}