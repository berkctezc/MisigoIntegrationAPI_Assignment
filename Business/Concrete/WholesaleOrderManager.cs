using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Abstract;

namespace Business.Concrete
{
    public class WholesaleOrderManager : IWholesaleOrderService//implement operations
    {
        public IResult Add(IOrder order)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(IOrder order)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(IOrder order)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<IOrder>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<IOrder> GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}