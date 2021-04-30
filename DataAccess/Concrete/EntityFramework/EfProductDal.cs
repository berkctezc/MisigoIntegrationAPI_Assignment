using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, EntegrasyonDbContext>, IProductDal
    {
        public List<ProductDto> GetProductDetails(Expression<Func<Product, bool>> filter = null)
        {
            using (EntegrasyonDbContext context = new EntegrasyonDbContext())
            {
                var result =
                   from product in filter is null
                       ? context.Products
                       : context.Products.Where(filter)
                   join attribute in context.Attributes on product.AttributesId equals attribute.Id
                   join variant in context.Variants on product.VariantsId equals variant.Id
                   select new ProductDto()
                   {
                       Id = product.Id,
                       ModelType = product.ModelType,
                       ItemTypeCode = product.ItemTypeCode,
                       ItemCode = product.ItemCode,
                       ItemDescription = product.ItemDescription,
                       ItemDimTypeCode = product.ItemDimTypeCode,
                       UnitOfMeasureCode1 = product.UnitOfMeasureCode1,
                       ItemTaxGrCode = product.ItemTaxGrCode,
                       ProductHierarchyID = product.ProductHierarchyID,
                       UsePOS = product.UsePOS,
                       UseStore = product.UseStore,
                       UseInternet = product.UseInternet,
                       //
                       AttributesId = attribute.Id,
                       AttributeTypeCode = attribute.AttributeTypeCode,
                       AttributeCode = attribute.AttributeCode,
                       //
                       VariantsId = variant.Id,
                       ColorCode = variant.ColorCode,
                       ItemDim1Code = variant.ItemDim1Code
                   };
                return result.ToList();
            }
        }

        public ProductDto GetProductDetailsById(Expression<Func<Product, bool>> filter)
        {
            using (EntegrasyonDbContext context = new EntegrasyonDbContext())
            {
                var result =
                    from product in filter is null
                        ? context.Products
                        : context.Products.Where(filter)
                    join attribute in context.Attributes on product.AttributesId equals attribute.Id
                    join variant in context.Variants on product.VariantsId equals variant.Id
                    select new ProductDto()
                    {
                        Id = product.Id,
                        ModelType = product.ModelType,
                        ItemTypeCode = product.ItemTypeCode,
                        ItemCode = product.ItemCode,
                        ItemDescription = product.ItemDescription,
                        ItemDimTypeCode = product.ItemDimTypeCode,
                        UnitOfMeasureCode1 = product.UnitOfMeasureCode1,
                        ItemTaxGrCode = product.ItemTaxGrCode,
                        ProductHierarchyID = product.ProductHierarchyID,
                        UsePOS = product.UsePOS,
                        UseStore = product.UseStore,
                        UseInternet = product.UseInternet,
                        //
                        AttributesId = attribute.Id,
                        AttributeTypeCode = attribute.AttributeTypeCode,
                        AttributeCode = attribute.AttributeCode,
                        //
                        VariantsId = variant.Id,
                        ColorCode = variant.ColorCode,
                        ItemDim1Code = variant.ItemDim1Code
                    };
                return result.SingleOrDefault();
            }
        }
    }
}