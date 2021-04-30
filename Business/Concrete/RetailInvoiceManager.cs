using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Abstract;

namespace Business.Concrete
{
    public class RetailInvoiceManager : IRetailInvoiceService//implement operations
    {
        public IResult Add(IInvoice invoice)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(IInvoice invoice)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(IInvoice invoice)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<IInvoice>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<IInvoice> GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}