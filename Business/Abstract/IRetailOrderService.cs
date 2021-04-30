using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRetailOrderService
    {
        IResult Add(RetailOrder retailOrder);
        IResult Delete(RetailOrder retailOrder);
        IResult Update(RetailOrder retailOrder);
        IDataResult<List<RetailOrder>> GetAll();
        IDataResult<RetailOrder> GetById(int id);
    }
}