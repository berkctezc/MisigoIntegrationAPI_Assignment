using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductService
    {
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);
        IDataResult<List<Product>> GetAll();
        IDataResult<List<ProductDto>> GetProductDetails();
        IDataResult<Product> GetById(int id);
        IDataResult<ProductDto> GetProductDetailsById(int id);
    }
}