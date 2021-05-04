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
    public class EfRetailOrderDal : EfEntityRepositoryBase<RetailOrder, EntegrasyonDbContext>, IRetailOrderDal
    {
        public List<RetailOrderDto> GetRetailOrderDetails(Expression<Func<RetailOrder, bool>> filter = null)
        {
            using (EntegrasyonDbContext context = new EntegrasyonDbContext())
            {
                var result =
                   from retailOrder in context.RetailOrders
                   join line in context.Lines on retailOrder.LinesId equals line.Id
                   join orderviainternetinfo in context.OrdersViaInternetInfo on retailOrder.OrdersViaInternetInfoId equals orderviainternetinfo.Id
                   join discount in context.Discounts on retailOrder.DiscountsId equals discount.Id
                   join payment in context.Payments on retailOrder.PaymentsId equals payment.Id
                   select new RetailOrderDto
                   {
                       Id = retailOrder.Id,
                       ModelType = retailOrder.ModelType,
                       CustomerCode = retailOrder.CustomerCode,
                       OfficeCode = retailOrder.OfficeCode,
                       StoreCode = retailOrder.StoreCode,
                       StoreWareHouseCode = retailOrder.StoreWareHouseCode,
                       ShipmentMethodCode = retailOrder.ShipmentMethodCode,
                       PosTerminalID=retailOrder.PosTerminalID,
                       OrderDate = retailOrder.OrderDate,
                       IsCompleted = retailOrder.IsCompleted,
                       IsSalesViaInternet = retailOrder.IsSalesViaInternet,
                       DocumentNumber = retailOrder.DocumentNumber,
                       Description = retailOrder.Description,
                       //
                       LinesId = line.Id,
                       ColorCode = line.ColorCode,
                       ItemCode = line.ColorCode,
                       ItemDim1Code = line.ItemDim1Code,
                       UsedBarcode = line.UsedBarcode,
                       Qty1 = line.Qty1,
                       LDisRate1 = line.LDisRate1,
                       LineDescription = line.LineDescription,
                       PriceVI = line.PriceVI,
                       //
                       OrdersViaInternetInfoId = orderviainternetinfo.Id,
                       SalesURL = orderviainternetinfo.SalesURL,
                       PaymentTypeCode = orderviainternetinfo.PaymentTypeCode,
                       PaymentTypeDescription = orderviainternetinfo.PaymentTypeDescription,
                       PaymentAgent = orderviainternetinfo.PaymentAgent,
                       PaymentDate = orderviainternetinfo.PaymentDate,
                       SendDate = orderviainternetinfo.SendDate,
                       //
                       DiscountsId = discount.Id,
                       DiscountTypeCode = discount.DiscountTypeCode,
                       Value = discount.Value,
                       DiscountReasonCode = discount.DiscountReasonCode,
                       IsPercentage = discount.IsPercentage,
                       //
                       PaymentsId = payment.Id,
                       PaymentType = payment.PaymentType,
                       Code = payment.Code,
                       CreditCardTypeCode = payment.CreditCardTypeCode,
                       InstallmentCount = payment.InstallmentCount,
                       Amount = payment.Amount
                   };
                return result.ToList();
            }
        }

        public RetailOrderDto GetRetailOrderDetailsById(Expression<Func<RetailOrder, bool>> filter)
        {
            using (EntegrasyonDbContext context = new EntegrasyonDbContext())
            {
                var result =
                   from retailOrder in filter is null
                       ? context.RetailOrders
                       : context.RetailOrders.Where(filter)
                   join line in context.Lines on retailOrder.LinesId equals line.Id
                   join orderviainternetinfo in context.OrdersViaInternetInfo on retailOrder.OrdersViaInternetInfoId equals orderviainternetinfo.Id
                   join discount in context.Discounts on retailOrder.DiscountsId equals discount.Id
                   join payment in context.Payments on retailOrder.PaymentsId equals payment.Id
                   select new RetailOrderDto
                   {
                       Id = retailOrder.Id,
                       ModelType = retailOrder.ModelType,
                       CustomerCode = retailOrder.CustomerCode,
                       OfficeCode = retailOrder.OfficeCode,
                       StoreCode = retailOrder.StoreCode,
                       StoreWareHouseCode = retailOrder.StoreWareHouseCode,
                       ShipmentMethodCode = retailOrder.ShipmentMethodCode,
                       PosTerminalID = retailOrder.PosTerminalID,
                       OrderDate = retailOrder.OrderDate,
                       IsCompleted = retailOrder.IsCompleted,
                       IsSalesViaInternet = retailOrder.IsSalesViaInternet,
                       DocumentNumber = retailOrder.DocumentNumber,
                       Description = retailOrder.Description,
                       //
                       LinesId = line.Id,
                       ColorCode = line.ColorCode,
                       ItemCode = line.ColorCode,
                       ItemDim1Code = line.ItemDim1Code,
                       UsedBarcode = line.UsedBarcode,
                       Qty1 = line.Qty1,
                       LDisRate1 = line.LDisRate1,
                       LineDescription = line.LineDescription,
                       PriceVI = line.PriceVI,
                       //
                       OrdersViaInternetInfoId = orderviainternetinfo.Id,
                       SalesURL = orderviainternetinfo.SalesURL,
                       PaymentTypeCode = orderviainternetinfo.PaymentTypeCode,
                       PaymentTypeDescription = orderviainternetinfo.PaymentTypeDescription,
                       PaymentAgent = orderviainternetinfo.PaymentAgent,
                       PaymentDate = orderviainternetinfo.PaymentDate,
                       SendDate = orderviainternetinfo.SendDate,
                       //
                       DiscountsId = discount.Id,
                       DiscountTypeCode = discount.DiscountTypeCode,
                       Value = discount.Value,
                       DiscountReasonCode = discount.DiscountReasonCode,
                       IsPercentage = discount.IsPercentage,
                       //
                       PaymentsId = payment.Id,
                       PaymentType = payment.PaymentType,
                       Code = payment.Code,
                       CreditCardTypeCode = payment.CreditCardTypeCode,
                       InstallmentCount = payment.InstallmentCount,
                       Amount = payment.Amount
                   };
                return result.SingleOrDefault();
            }
        }
    }
}