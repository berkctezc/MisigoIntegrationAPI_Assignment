using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;

namespace Business.ValidationRoutes.FluentValidation
{
    public class RetailCustomerValidator:AbstractValidator<RetailCustomerDto>
    {
        public RetailCustomerValidator()
        {
            Transform(from: rc => rc.AddressTypeCode, to: value => int.TryParse(value, out int val) ? (int?) val : null).NotEmpty().NotNull().GreaterThanOrEqualTo(1).LessThanOrEqualTo(3);
            Transform(from: rc => rc.CommunicationTypeCode, to: value => int.TryParse(value, out int val) ? (int?) val : null).NotEmpty().NotNull().GreaterThanOrEqualTo(1).LessThanOrEqualTo(7);

        }
    }
}
