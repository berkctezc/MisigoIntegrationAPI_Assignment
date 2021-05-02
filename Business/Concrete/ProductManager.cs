using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRoutes.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [ValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        [CacheRemoveAspect("IProductService.Get")]
        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        [ValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public IResult Update(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductUpdated);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductsListed);
        }

        [CacheAspect]
        public IDataResult<List<ProductDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDto>>(_productDal.GetProductDetails());
        }

        [CacheAspect]
        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.Id == id));
        }

        [CacheAspect]
        public IDataResult<ProductDto> GetProductDetailsById(int id)
        {
            return new SuccessDataResult<ProductDto>(_productDal.GetProductDetailsById(p => p.Id == id));
        }
    }
}