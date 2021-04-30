using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IRetailOrderService
    {
        IResult Add(RetailOrder retailOrder);
        IResult Delete(RetailOrder retailOrder);
        IResult Update(RetailOrder retailOrder);
        IDataResult<List<RetailOrder>> GetAll();
        IDataResult<List<RetailOrderDto>> GetRetailOrderDetails();
        IDataResult<RetailOrder> GetById(int id);
        IDataResult<RetailOrderDto> GetRetailOrderDetailsById(int id);
    }
}