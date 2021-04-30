using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Abstract;

namespace Business.Concrete
{
    public class WholesaleCustomerManager : IWholesaleCustomerService//implement operations
    {
        public IResult Add(ICustomer customer)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(ICustomer customer)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(ICustomer customer)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<ICustomer>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<ICustomer> GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}