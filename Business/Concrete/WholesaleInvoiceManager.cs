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
    public class WholesaleInvoiceManager : IWholesaleInvoiceService
    {
        private readonly IWholesaleInvoiceDal _wholesaleInvoiceDal;

        public WholesaleInvoiceManager(IWholesaleInvoiceDal wholesaleInvoiceDal)
        {
            _wholesaleInvoiceDal = wholesaleInvoiceDal;
        }

        [CacheRemoveAspect("IWholesaleInvoiceService.Get")]
        public IResult Add(WholesaleInvoice wholesaleInvoice)
        {
            _wholesaleInvoiceDal.Add(wholesaleInvoice);
            return new SuccessResult(Messages.WholesaleInvoiceAdded);
        }

        [CacheRemoveAspect("IWholesaleInvoiceService.Get")]
        public IResult Delete(WholesaleInvoice wholesaleInvoice)
        {
            _wholesaleInvoiceDal.Delete(wholesaleInvoice);
            return new SuccessResult(Messages.WholesaleInvoiceDeleted);
        }

        [CacheRemoveAspect("IWholesaleInvoiceService.Get")]
        public IResult Update(WholesaleInvoice wholesaleInvoice)
        {
            _wholesaleInvoiceDal.Update(wholesaleInvoice);
            return new SuccessResult(Messages.WholesaleInvoiceUpdated);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<WholesaleInvoice>> GetAll()
        {
            return new SuccessDataResult<List<WholesaleInvoice>>(_wholesaleInvoiceDal.GetAll(), Messages.WholesaleInvoicesListed);
        }

        [CacheAspect]
        public IDataResult<List<WholesaleInvoiceDto>> GetWholesaleInvoiceDetails()
        {
            return new SuccessDataResult<List<WholesaleInvoiceDto>>(_wholesaleInvoiceDal.GetWholesaleInvoiceDetails());
        }

        [CacheAspect]
        public IDataResult<WholesaleInvoice> GetById(int id)
        {
            return new SuccessDataResult<WholesaleInvoice>(_wholesaleInvoiceDal.Get(wID => wID.Id == id));
        }

        public IDataResult<WholesaleInvoiceDto> GetWholesaleInvoiceDetailsById(int id)
        {
            return new SuccessDataResult<WholesaleInvoiceDto>(_wholesaleInvoiceDal.GetWholesaleInvoiceDetailsById(wID => wID.Id == id));
        }
    }
}