using Entities.DTOs;
using FluentValidation;

namespace Business.ValidationRoutes.FluentValidation
{
    public class RetailInvoiceValidator : AbstractValidator<RetailInvoiceDto>
    {
        public RetailInvoiceValidator()
        {
            //incomplete
            Transform(from: ri => ri.ShipmentMethodCode, to: value => int.TryParse(value, out int val) ? (int?) val : null).NotEmpty().NotNull().GreaterThanOrEqualTo(1).LessThanOrEqualTo(3);
            RuleFor(rc => rc.PaymentTypeCode).NotEmpty().NotNull();
        }
    }
}
