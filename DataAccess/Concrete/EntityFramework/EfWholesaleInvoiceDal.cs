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
    public class EfWholesaleInvoiceDal : EfEntityRepositoryBase<WholesaleInvoice, EntegrasyonDbContext>, IWholesaleInvoiceDal
    {
        public List<WholesaleInvoiceDto> GetWholesaleInvoiceDetails(Expression<Func<WholesaleInvoice, bool>> filter = null)
        {
            using (EntegrasyonDbContext context = new EntegrasyonDbContext())
            {
                var result =
                   from wholesaleInvoice in filter is null
                       ? context.WholesaleInvoices
                       : context.WholesaleInvoices.Where(filter)
                   join line in context.Lines on wholesaleInvoice.LinesId equals line.Id
                   join sumline in context.SumLines on wholesaleInvoice.SumLinesId equals sumline.Id
                   join salesviainternetinfo in context.SaleViaInternetInfos on wholesaleInvoice.SalesViaInternetInfoId equals salesviainternetinfo.Id
                   join discount in context.Discounts on wholesaleInvoice.DiscountsId equals discount.Id
                   join payment in context.Payments on wholesaleInvoice.PaymentsId equals payment.Id
                   select new WholesaleInvoiceDto
                   {
                       Id = wholesaleInvoice.Id,
                       ModelType = wholesaleInvoice.ModelType,
                       CustomerCode = wholesaleInvoice.CustomerCode,
                       CompanyCode = wholesaleInvoice.CompanyCode,
                       OfficeCode = wholesaleInvoice.OfficeCode,
                       WareHouseCode = wholesaleInvoice.WareHouseCode,
                       DeliveryCompanyCode = wholesaleInvoice.DeliveryCompanyCode,
                       ShipmentMethodCode = wholesaleInvoice.ShipmentMethodCode,
                       InvoiceDate = wholesaleInvoice.InvoiceDate,
                       Series = wholesaleInvoice.Series,
                       SeriesNumber = wholesaleInvoice.SeriesNumber,
                       IsCompleted = wholesaleInvoice.IsCompleted,
                       IsReturn = wholesaleInvoice.IsReturn,
                       IsSalesViaInternet = wholesaleInvoice.IsSalesViaInternet,
                       SubCurrAccID = wholesaleInvoice.SubCurrAccID,
                       Description = wholesaleInvoice.Description,
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
                       SumLinesId = sumline.Id,
                       LotBarcode = sumline.LotBarcode,
                       SumLinesQty1 = sumline.Qty1,
                       //
                       SalesViaInternetInfoId = salesviainternetinfo.Id,
                       SalesURL = salesviainternetinfo.SalesURL,
                       PaymentTypeCode = salesviainternetinfo.PaymentTypeCode,
                       PaymentTypeDescription = salesviainternetinfo.PaymentTypeDescription,
                       PaymentAgent = salesviainternetinfo.PaymentAgent,
                       PaymentDate = salesviainternetinfo.PaymentDate,
                       SendDate = salesviainternetinfo.SendDate,
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

        public WholesaleInvoiceDto GetWholesaleInvoiceDetailsById(Expression<Func<WholesaleInvoice, bool>> filter)
        {
            using (EntegrasyonDbContext context = new EntegrasyonDbContext())
            {
                var result =
                   from wholesaleInvoice in filter is null
                       ? context.WholesaleInvoices
                       : context.WholesaleInvoices.Where(filter)
                   join line in context.Lines on wholesaleInvoice.LinesId equals line.Id
                   join sumline in context.SumLines on wholesaleInvoice.SumLinesId equals sumline.Id
                   join salesviainternetinfo in context.SaleViaInternetInfos on wholesaleInvoice.SalesViaInternetInfoId equals salesviainternetinfo.Id
                   join discount in context.Discounts on wholesaleInvoice.DiscountsId equals discount.Id
                   join payment in context.Payments on wholesaleInvoice.PaymentsId equals payment.Id
                   select new WholesaleInvoiceDto
                   {
                       Id = wholesaleInvoice.Id,
                       ModelType = wholesaleInvoice.ModelType,
                       CustomerCode = wholesaleInvoice.CustomerCode,
                       CompanyCode = wholesaleInvoice.CompanyCode,
                       OfficeCode = wholesaleInvoice.OfficeCode,
                       WareHouseCode = wholesaleInvoice.WareHouseCode,
                       DeliveryCompanyCode = wholesaleInvoice.DeliveryCompanyCode,
                       ShipmentMethodCode = wholesaleInvoice.ShipmentMethodCode,
                       InvoiceDate = wholesaleInvoice.InvoiceDate,
                       Series = wholesaleInvoice.Series,
                       SeriesNumber = wholesaleInvoice.SeriesNumber,
                       IsCompleted = wholesaleInvoice.IsCompleted,
                       IsReturn = wholesaleInvoice.IsReturn,
                       IsSalesViaInternet = wholesaleInvoice.IsSalesViaInternet,
                       SubCurrAccID = wholesaleInvoice.SubCurrAccID,
                       Description = wholesaleInvoice.Description,
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
                       SumLinesId = sumline.Id,
                       LotBarcode = sumline.LotBarcode,
                       SumLinesQty1 = sumline.Qty1,
                       //
                       SalesViaInternetInfoId = salesviainternetinfo.Id,
                       SalesURL = salesviainternetinfo.SalesURL,
                       PaymentTypeCode = salesviainternetinfo.PaymentTypeCode,
                       PaymentTypeDescription = salesviainternetinfo.PaymentTypeDescription,
                       PaymentAgent = salesviainternetinfo.PaymentAgent,
                       PaymentDate = salesviainternetinfo.PaymentDate,
                       SendDate = salesviainternetinfo.SendDate,
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