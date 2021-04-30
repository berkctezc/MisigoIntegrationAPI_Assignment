using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

//implement dtos on services
namespace Business.Concrete
{
    public class RetailOrderManager : IRetailOrderService
    {
        private readonly IRetailOrderDal _retailOrderDal;

        public RetailOrderManager(IRetailOrderDal retailOrderDal)
        {
            _retailOrderDal = retailOrderDal;
        }

        [CacheRemoveAspect("IRetailOrderService.Get")]
        public IResult Add(RetailOrder retailOrder)
        {
            _retailOrderDal.Add(retailOrder);
            return new SuccessResult(Messages.RetailOrderAdded);
        }

        [CacheRemoveAspect("IRetailOrderService.Get")]
        public IResult Delete(RetailOrder retailOrder)
        {
            _retailOrderDal.Delete(retailOrder);
            return new SuccessResult(Messages.RetailOrderDeleted);
        }

        [CacheRemoveAspect("IRetailOrderService.Get")]
        public IResult Update(RetailOrder retailOrder)
        {
            _retailOrderDal.Update(retailOrder);
            return new SuccessResult(Messages.RetailOrderUpdated);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<RetailOrder>> GetAll()
        {
            return new SuccessDataResult<List<RetailOrder>>(_retailOrderDal.GetAll(), Messages.RetailOrdersListed);
        }

        [CacheAspect]
        public IDataResult<RetailOrder> GetById(int id)
        {
            return new SuccessDataResult<RetailOrder>(_retailOrderDal.Get(rOD => rOD.Id == id));
        }
    }
}