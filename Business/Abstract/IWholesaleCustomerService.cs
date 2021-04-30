using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IWholesaleCustomerService
    {
        IResult Add(WholesaleCustomer wholesaleCustomer);
        IResult Delete(WholesaleCustomer wholesaleCustomer);
        IResult Update(WholesaleCustomer wholesaleCustomer);
        IDataResult<List<WholesaleCustomer>> GetAll();
        IDataResult<List<WholesaleCustomerDto>> GetWholesaleCustomerDetails();
        IDataResult<WholesaleCustomer> GetById(int id);
        IDataResult<WholesaleCustomerDto> GetWholesaleCustomerDetailsById(int id);
    }
}