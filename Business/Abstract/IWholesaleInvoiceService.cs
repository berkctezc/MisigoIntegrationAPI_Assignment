using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IWholesaleInvoiceService
    {
        IResult Add(WholesaleInvoice wholesaleInvoice);
        IResult Delete(WholesaleInvoice wholesaleInvoice);
        IResult Update(WholesaleInvoice wholesaleInvoice);
        IDataResult<List<WholesaleInvoice>> GetAll();
        IDataResult<List<WholesaleInvoiceDto>> GetWholesaleInvoiceDetails();
        IDataResult<WholesaleInvoice> GetById(int id);
        IDataResult<WholesaleInvoiceDto> GetWholesaleInvoiceDetailsById(int id);
    }
}