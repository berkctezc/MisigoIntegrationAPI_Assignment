using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class WholesaleCustomerManager : IWholesaleCustomerService
    {
        private readonly IWholesaleCustomerDal _wholesaleCustomerDal;

        public WholesaleCustomerManager(IWholesaleCustomerDal wholesaleCustomerDal)
        {
            _wholesaleCustomerDal = wholesaleCustomerDal;
        }

        [CacheRemoveAspect("IWholesaleCustomerService.Get")]
        public IResult Add(WholesaleCustomer wholesaleCustomer)
        {
            _wholesaleCustomerDal.Add(wholesaleCustomer);
            return new SuccessResult(Messages.WholesaleCustomerAdded);
        }

        [CacheRemoveAspect("IWholesaleCustomerService.Get")]
        public IResult Delete(WholesaleCustomer wholesaleCustomer)
        {
            _wholesaleCustomerDal.Delete(wholesaleCustomer);
            return new SuccessResult(Messages.WholesaleCustomerDeleted);
        }

        [CacheRemoveAspect("IWholesaleCustomerService.Get")]
        public IResult Update(WholesaleCustomer wholesaleCustomer)
        {
            _wholesaleCustomerDal.Update(wholesaleCustomer);
            return new SuccessResult(Messages.WholesaleCustomerUpdated);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<WholesaleCustomer>> GetAll()
        {
            return new SuccessDataResult<List<WholesaleCustomer>>(_wholesaleCustomerDal.GetAll(), Messages.WholesaleCustomersListed);
        }

        [CacheAspect]
        public IDataResult<List<WholesaleCustomerDto>> GetWholesaleCustomerDetails()
        {
            return new SuccessDataResult<List<WholesaleCustomerDto>>(_wholesaleCustomerDal.GetWholesaleCustomerDetails());
        }

        [CacheAspect]
        public IDataResult<WholesaleCustomer> GetById(int id)
        {
            return new SuccessDataResult<WholesaleCustomer>(_wholesaleCustomerDal.Get(wCD => wCD.Id == id));
        }

        [CacheAspect]
        public IDataResult<WholesaleCustomerDto> GetWholesaleCustomerDetailsById(int id)
        {
            return new SuccessDataResult<WholesaleCustomerDto>(_wholesaleCustomerDal.GetWholesaleCustomerDetailsById(wCD => wCD.Id == id));
        }
    }
}