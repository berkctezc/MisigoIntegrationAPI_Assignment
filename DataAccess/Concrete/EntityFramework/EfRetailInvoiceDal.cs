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
    public class EfRetailInvoiceDal : EfEntityRepositoryBase<RetailInvoice, EntegrasyonDbContext>, IRetailInvoiceDal
    {
        public List<RetailInvoiceDto> GetRetailInvoiceDetails(Expression<Func<RetailInvoice, bool>> filter = null)
        {
            using (EntegrasyonDbContext context = new EntegrasyonDbContext())
            {
                var result =
                   from retailInvoice in filter is null
                       ? context.RetailInvoices
                       : context.RetailInvoices.Where(filter)
                   join line in context.Lines on retailInvoice.LinesId equals line.Id
                   join sumline in context.SumLines on retailInvoice.SumLinesId equals sumline.Id
                   join salesviainternetinfo in context.SaleViaInternetInfos on retailInvoice.SalesViaInternetInfoId equals salesviainternetinfo.Id
                   join discount in context.Discounts on retailInvoice.DiscountsId equals discount.Id
                   join payment in context.Payments on retailInvoice.PaymentsId equals payment.Id
                   select new RetailInvoiceDto()
                   {
                       Id = retailInvoice.Id,
                       ModelType = retailInvoice.ModelType,
                       CustomerCode = retailInvoice.CustomerCode,
                       OfficeCode = retailInvoice.OfficeCode,
                       StoreCode = retailInvoice.StoreCode,
                       WarehouseCode = retailInvoice.WarehouseCode,
                       DeliveryCompanyCode = retailInvoice.DeliveryCompanyCode,
                       ShipmentMethodCode = retailInvoice.ShipmentMethodCode,
                       PosTerminalID = retailInvoice.PosTerminalID,
                       Series = retailInvoice.Series,
                       SeriesNumber = retailInvoice.SeriesNumber,
                       InvoiceDate = retailInvoice.InvoiceDate,
                       IsCompleted = retailInvoice.IsCompleted,
                       IsReturn = retailInvoice.IsReturn,
                       IsSalesViaInternet = retailInvoice.IsSalesViaInternet,
                       Description = retailInvoice.Description,
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
                       SalesViaInternetInfoId = salesviainternetinfo.Id,
                       SalesURL = salesviainternetinfo.SalesURL,
                       PaymentTypeCode = salesviainternetinfo.PaymentTypeCode,
                       PaymentTypeDescription = salesviainternetinfo.PaymentTypeDescription,
                       PaymentAgent = salesviainternetinfo.PaymentAgent,
                       PaymentDate = salesviainternetinfo.PaymentDate,
                       SendDate = salesviainternetinfo.SendDate,
                       //
                       SumLinesId = sumline.Id,
                       LotBarcode = sumline.LotBarcode,
                       SumLinesQty1 = sumline.Qty1,
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

        public RetailInvoiceDto GetRetailInvoiceDetailsById(Expression<Func<RetailInvoice, bool>> filter)
        {
            using (EntegrasyonDbContext context = new EntegrasyonDbContext())
            {
                var result =
                   from retailInvoice in filter is null
                       ? context.RetailInvoices
                       : context.RetailInvoices.Where(filter)
                   join line in context.Lines on retailInvoice.LinesId equals line.Id
                   join sumline in context.SumLines on retailInvoice.SumLinesId equals sumline.Id
                   join salesviainternetinfo in context.SaleViaInternetInfos on retailInvoice.SalesViaInternetInfoId equals salesviainternetinfo.Id
                   join discount in context.Discounts on retailInvoice.DiscountsId equals discount.Id
                   join payment in context.Payments on retailInvoice.PaymentsId equals payment.Id
                   select new RetailInvoiceDto()
                   {
                       Id = retailInvoice.Id,
                       ModelType = retailInvoice.ModelType,
                       CustomerCode = retailInvoice.CustomerCode,
                       OfficeCode = retailInvoice.OfficeCode,
                       StoreCode = retailInvoice.StoreCode,
                       WarehouseCode = retailInvoice.WarehouseCode,
                       DeliveryCompanyCode = retailInvoice.DeliveryCompanyCode,
                       ShipmentMethodCode = retailInvoice.ShipmentMethodCode,
                       PosTerminalID = retailInvoice.PosTerminalID,
                       Series = retailInvoice.Series,
                       SeriesNumber = retailInvoice.SeriesNumber,
                       InvoiceDate = retailInvoice.InvoiceDate,
                       IsCompleted = retailInvoice.IsCompleted,
                       IsReturn = retailInvoice.IsReturn,
                       IsSalesViaInternet = retailInvoice.IsSalesViaInternet,
                       Description = retailInvoice.Description,
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
                       SalesViaInternetInfoId = salesviainternetinfo.Id,
                       SalesURL = salesviainternetinfo.SalesURL,
                       PaymentTypeCode = salesviainternetinfo.PaymentTypeCode,
                       PaymentTypeDescription = salesviainternetinfo.PaymentTypeDescription,
                       PaymentAgent = salesviainternetinfo.PaymentAgent,
                       PaymentDate = salesviainternetinfo.PaymentDate,
                       SendDate = salesviainternetinfo.SendDate,
                       //
                       SumLinesId = sumline.Id,
                       LotBarcode = sumline.LotBarcode,
                       SumLinesQty1 = sumline.Qty1,
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