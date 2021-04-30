using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IWholesaleOrderService
    {
        IResult Add(WholesaleOrder wholesaleOrder);
        IResult Delete(WholesaleOrder wholesaleOrder);
        IResult Update(WholesaleOrder wholesaleOrder);
        IDataResult<List<WholesaleOrder>> GetAll();
        IDataResult<WholesaleOrder> GetById(int id);
    }
}