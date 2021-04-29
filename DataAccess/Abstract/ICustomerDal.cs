using Core.DataAccess;
using Entities.Abstract;

namespace DataAccess.Abstract
{
    public interface ICustomerDal:IEntityRepository<ICustomer>
    {
    }
}
