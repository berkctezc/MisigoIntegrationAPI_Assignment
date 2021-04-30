using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IWholesaleInvoiceService
    {
        IResult Add(WholesaleInvoice wholesaleInvoice);
        IResult Delete(WholesaleInvoice wholesaleInvoice);
        IResult Update(WholesaleInvoice wholesaleInvoice);
        IDataResult<List<WholesaleInvoice>> GetAll();
        IDataResult<WholesaleInvoice> GetById(int id);
    }
}