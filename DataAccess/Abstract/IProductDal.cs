using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDto> GetProductDetails(Expression<Func<Product, bool>> filter = null);
        ProductDto GetProductDetailsById(Expression<Func<Product, bool>> filter);
    }
}