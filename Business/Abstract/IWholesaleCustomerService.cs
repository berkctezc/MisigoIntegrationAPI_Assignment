using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IWholesaleCustomerService
    {
        IResult Add(WholesaleCustomer wholesaleCustomer);
        IResult Delete(WholesaleCustomer wholesaleCustomer);
        IResult Update(WholesaleCustomer wholesaleCustomer);
        IDataResult<List<WholesaleCustomer>> GetAll();
        IDataResult<WholesaleCustomer> GetById(int id);
    }
}