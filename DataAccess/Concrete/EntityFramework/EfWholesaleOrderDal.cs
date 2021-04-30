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
    public class EfWholesaleOrderDal : EfEntityRepositoryBase<WholesaleOrder, EntegrasyonDbContext>, IWholesaleOrderDal
    {
        public List<WholesaleOrderDto> GetWholesaleOrderDetails(Expression<Func<WholesaleOrder, bool>> filter = null)
        {
            using (EntegrasyonDbContext context = new EntegrasyonDbContext())
            {
                var result =
                    from wholesaleOrder in filter is null
                        ? context.WholesaleOrders
                        : context.WholesaleOrders.Where(filter)
                    join line in context.Lines on wholesaleOrder.LinesId equals line.Id
                    join orderviainternetinfo in context.OrderViaInternetInfos on wholesaleOrder.OrdersViaInternetInfoId
                        equals orderviainternetinfo.Id
                    join discount in context.Discounts on wholesaleOrder.DiscountsId equals discount.Id
                    join payment in context.Payments on wholesaleOrder.PaymentsId equals payment.Id
                    select new WholesaleOrderDto
                    {
                        Id = wholesaleOrder.Id,
                        ModelType = wholesaleOrder.ModelType,
                        CustomerCode = wholesaleOrder.CustomerCode,
                        OfficeCode = wholesaleOrder.OfficeCode,
                        WarehouseCode = wholesaleOrder.WarehouseCode,
                        DeliveryCompanyCode = wholesaleOrder.DeliveryCompanyCode,
                        ShipmentMethodCode = wholesaleOrder.ShipmentMethodCode,
                        PosTerminalID = wholesaleOrder.PosTerminalID,
                        OrderDate = wholesaleOrder.OrderDate,
                        IsCompleted = wholesaleOrder.IsCompleted,
                        IsSalesViaInternet = wholesaleOrder.IsSalesViaInternet,
                        DocumentNumber = wholesaleOrder.DocumentNumber,
                        Description = wholesaleOrder.Description,
                        //
                        OrdersViaInternetInfoId = orderviainternetinfo.Id,
                        SalesURL = orderviainternetinfo.SalesURL,
                        PaymentTypeCode = orderviainternetinfo.PaymentTypeCode,
                        PaymentTypeDescription = orderviainternetinfo.PaymentTypeDescription,
                        PaymentAgent = orderviainternetinfo.PaymentAgent,
                        PaymentDate = orderviainternetinfo.PaymentDate,
                        SendDate = orderviainternetinfo.SendDate,
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
    }
}