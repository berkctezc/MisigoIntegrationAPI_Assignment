using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IRetailCustomerService
    {
        IResult Add(RetailCustomer retailCustomer);
        IResult Delete(RetailCustomer retailCustomer);
        IResult Update(RetailCustomer retailCustomer);
        IDataResult<List<RetailCustomer>> GetAll();
        IDataResult<List<RetailCustomerDto>> GetRetailCustomerDetails();
        IDataResult<RetailCustomer> GetById(int id);
        IDataResult<RetailCustomerDto> GetRetailCustomerDetailsById(int id);
    }
}