using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Abstract;

namespace Business.Abstract
{
    public interface IWholesaleCustomerService
    {
        IResult Add(ICustomer customer);
        IResult Delete(ICustomer customer);
        IResult Update(ICustomer customer);
        IDataResult<List<ICustomer>> GetAll();
        IDataResult<ICustomer> GetById(int id);
    }
}