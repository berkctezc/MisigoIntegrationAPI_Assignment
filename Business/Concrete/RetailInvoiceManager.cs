using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

//implement dtos on services
namespace Business.Concrete
{
    public class RetailInvoiceManager : IRetailInvoiceService
    {
        private readonly IRetailInvoiceDal _retailInvoiceDal;

        public RetailInvoiceManager(IRetailInvoiceDal retailInvoiceDal)
        {
            _retailInvoiceDal = retailInvoiceDal;
        }

        [CacheRemoveAspect("IRetailInvoiceService.Get")]
        public IResult Add(RetailInvoice retailInvoice)
        {
            _retailInvoiceDal.Add(retailInvoice);
            return new SuccessResult(Messages.RetailInvoiceAdded);
        }

        [CacheRemoveAspect("IRetailInvoiceService.Get")]
        public IResult Delete(RetailInvoice retailInvoice)
        {
            _retailInvoiceDal.Delete(retailInvoice);
            return new SuccessResult(Messages.RetailInvoiceDeleted);
        }

        [CacheRemoveAspect("IRetailInvoiceService.Get")]
        public IResult Update(RetailInvoice retailInvoice)
        {
            _retailInvoiceDal.Update(retailInvoice);
            return new SuccessResult(Messages.RetailInvoiceUpdated);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<RetailInvoice>> GetAll()
        {
            return new SuccessDataResult<List<RetailInvoice>>(_retailInvoiceDal.GetAll(), Messages.RetailInvoicesListed);
        }

        [CacheAspect]
        public IDataResult<List<RetailInvoiceDto>> GetRetailInvoiceDetails()
        {
            return new SuccessDataResult<List<RetailInvoiceDto>>(_retailInvoiceDal.GetRetailInvoiceDetails());
        }

        [CacheAspect]
        public IDataResult<RetailInvoice> GetById(int id)
        {
            return new SuccessDataResult<RetailInvoice>(_retailInvoiceDal.Get(rID => rID.Id == id));
        }

        [CacheAspect]
        public IDataResult<RetailInvoiceDto> GetRetailInvoiceDetailsById(int id)
        {
            return new SuccessDataResult<RetailInvoiceDto>(_retailInvoiceDal.GetRetailInvoiceDetailsById());
        }
    }
}