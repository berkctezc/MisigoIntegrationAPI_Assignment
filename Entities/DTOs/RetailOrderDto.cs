using System;
using Core.Entities;

namespace Entities.DTOs
{
    public class RetailOrderDto:IDto
    {
        public int Id { get; set; }
        public int ModelType { get; set; }
        public string CustomerCode { get; set; }
        public string OfficeCode { get; set; }
        public string StoreCode { get; set; }
        public string StoreWareHouseCode { get; set; }
        public string ShipmentMethodCode { get; set; }
        public DateTime OrderDate { get; set; }
        public string IsCompleted { get; set; }
        public bool CustomerTypeCode { get; set; }
        public bool IsSalesViaInternet { get; set; }
        public string DocumentNumber { get; set; }
        public Guid SubCurrAccID { get; set; }
        public string Description { get; set; }
        //
        public int LinesId { get; set; }
        public string ColorCode { get; set; }
        public string ItemCode { get; set; }
        public string ItemDim1Code { get; set; }
        public string UsedBarcode { get; set; }
        public float Qty1 { get; set; }
        public float LDisRate1 { get; set; }
        public string LineDescription { get; set; }
        public decimal PriceVI { get; set; }
        //
        public int SumLinesId { get; set; }
        public string LotBarcode { get; set; }
        public float SumLinesQty1 { get; set; }
        //
        public int OrdersViaInternetInfoId { get; set; }
        public string SalesURL { get; set; }
        public int PaymentTypeCode { get; set; }
        public string PaymentTypeDescription { get; set; }
        public string PaymentAgent { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime SendDate { get; set; }
        //
        public int DiscountsId { get; set; }
        public string DiscountTypeCode { get; set; }
        public float Value { get; set; }
        public int DiscountReasonCode { get; set; }
        public bool IsPercentage { get; set; }
        //
        public int PaymentsId { get; set; }
        public int PaymentType { get; set; }
        public string Code { get; set; }
        public string CreditCardTypeCode { get; set; }
        public int InstallmentCount { get; set; }
        public decimal Amount { get; set; }
    }
}
