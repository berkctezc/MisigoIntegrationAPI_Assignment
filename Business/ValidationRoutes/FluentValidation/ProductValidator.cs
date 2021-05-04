using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRoutes.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ItemTypeCode).NotEmpty().NotNull();
            RuleFor(p => p.ItemDimTypeCode).NotEmpty().NotNull();
        }
    }
}
