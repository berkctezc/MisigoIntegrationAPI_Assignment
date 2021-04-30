using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

//implement Dtos on services
namespace Business.Concrete
{
    public class WholesaleOrderManager : IWholesaleOrderService
    {
        private readonly IWholesaleOrderDal _wholesaleOrderDal;

        public WholesaleOrderManager(IWholesaleOrderDal wholesaleOrderDal)
        {
            _wholesaleOrderDal = wholesaleOrderDal;
        }

        [CacheRemoveAspect("IWholesaleOrderService.Get")]
        public IResult Add(WholesaleOrder wholesaleOrder)
        {
            _wholesaleOrderDal.Add(wholesaleOrder);
            return new SuccessResult(Messages.WholesaleOrderAdded);
        }

        [CacheRemoveAspect("IWholesaleOrderService.Get")]
        public IResult Delete(WholesaleOrder wholesaleOrder)
        {
            _wholesaleOrderDal.Delete(wholesaleOrder);
            return new SuccessResult(Messages.WholesaleOrderDeleted);
        }

        [CacheRemoveAspect("IWholesaleOrderService.Get")]
        public IResult Update(WholesaleOrder wholesaleOrder)
        {
            _wholesaleOrderDal.Update(wholesaleOrder);
            return new SuccessResult(Messages.WholesaleOrderUpdated);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<WholesaleOrder>> GetAll()
        {
            return new SuccessDataResult<List<WholesaleOrder>>(_wholesaleOrderDal.GetAll(), Messages.WholesaleOrdersListed);
        }

        [CacheAspect]
        public IDataResult<WholesaleOrder> GetById(int id)
        {
            return new SuccessDataResult<WholesaleOrder>(_wholesaleOrderDal.Get( wOD=> wOD.Id == id));
        }
    }
}