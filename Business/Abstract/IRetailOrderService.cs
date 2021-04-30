using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Abstract;

namespace Business.Abstract
{
    public interface IRetailOrderService
    {
        IResult Add(IOrder order);
        IResult Delete(IOrder order);
        IResult Update(IOrder order);
        IDataResult<List<IOrder>> GetAll();
        IDataResult<IOrder> GetById(int id);
    }
}