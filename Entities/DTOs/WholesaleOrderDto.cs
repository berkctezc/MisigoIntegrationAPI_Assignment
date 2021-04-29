using System;
using Core.Entities;

namespace Entities.DTOs
{
   public class WholesaleOrderDto:IDto
    {
        public int Id { get; set; }
        public int ModelType { get; set; }
        public string CustomerCode { get; set; }
        public string OfficeCode { get; set; }
        public string WarehouseCode { get; set; }
        public string DeliveryCompanyCode { get; set; }
        public string ShipmentMethodCode { get; set; }
        public int PosTerminalID { get; set; }
        public DateTime OrderDate { set; get; }
        public string IsCompleted { get; set; }
        public bool IsSalesViaInternet { get; set; }
        public string DocumentNumber { get; set; }
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
        public int OrdersViaInternetInfoId { get; set; }
        public string SalesURL { get; set; }
        public int PaymentTypeCode { get; set; }
        public string PaymentTypeDescription { get; set; }
        public string PaymentAgent { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime SendDate { get; set; }
        //
        public int DiscountsId { set; get; }
        public string DiscountTypeCode { get; set; }
        public float Value { get; set; }
        public int DiscountReasonCode { get; set; }
        public bool IsPercentage { get; set; }
        //
        public int PaymentsId { set; get; }
        public int PaymentType { get; set; }
        public string Code { get; set; }
        public string CreditCardTypeCode { get; set; }
        public int InstallmentCount { get; set; }
        public decimal Amount { get; set; }
    }
}
