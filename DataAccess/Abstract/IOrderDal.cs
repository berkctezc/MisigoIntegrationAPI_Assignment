using Core.DataAccess;
using Entities.Abstract;

namespace DataAccess.Abstract
{
    public interface IOrderDal:IEntityRepository<IOrder>
    {
    }
}
