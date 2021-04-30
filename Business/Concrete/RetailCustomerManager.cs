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
    public class RetailCustomerManager : IRetailCustomerService
    {
        private readonly IRetailCustomerDal _retailCustomerDal;

        public RetailCustomerManager(IRetailCustomerDal retailCustomerDal)
        {
            _retailCustomerDal = retailCustomerDal;
        }

        [CacheRemoveAspect("IRetailCustomerService.Get")]
        public IResult Add(RetailCustomer retailCustomer)
        {
            _retailCustomerDal.Add(retailCustomer);
            return new SuccessResult(Messages.RetailCustomerAdded);
        }

        [CacheRemoveAspect("IRetailCustomerService.Get")]
        public IResult Delete(RetailCustomer retailCustomer)
        {
            _retailCustomerDal.Delete(retailCustomer);
            return new SuccessResult(Messages.RetailCustomerDeleted);
        }

        [CacheRemoveAspect("IRetailCustomerService.Get")]
        public IResult Update(RetailCustomer retailCustomer)
        {
            _retailCustomerDal.Update(retailCustomer);
            return new SuccessResult(Messages.RetailCustomerUpdated);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<RetailCustomer>> GetAll()
        {
            return new SuccessDataResult<List<RetailCustomer>>(_retailCustomerDal.GetAll(), Messages.RetailCustomersListed);
        }

        [CacheAspect]
        public IDataResult<RetailCustomer> GetById(int id)
        {
            return new SuccessDataResult<RetailCustomer>(_retailCustomerDal.Get(rCD => rCD.Id == id));
        }
    }
}