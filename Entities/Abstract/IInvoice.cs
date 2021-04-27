using System;
using System.Collections.Generic;
using Core.Entities;
using Entities.Types;

namespace Entities.Abstract
{
    public interface IInvoice:IEntity
    {
        public int Id { get; set; }
        public int ModelType { get; set; }
        public string CustomerCode { get; set; }
        public string OfficeCode { get; set; }
        public string WarehouseCode { get; set; }
        public string DeliveryCompanyCode { get; set; }
        public string ShipmentMethodCode { get; set; }
        public DateTime InvoiceDate { set; get; }
        public string Series { get; set; }
        public int SeriesNumber { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsReturn { get; set; }
        public bool IsSalesViaInternet { get; set; }
        public string Description { get; set; }
        public List<Line> Lines { get; set; }
        public List<SumLine> SumLines { get; set; }
        public SaleViaInternetInfo SalesViaInternetInfo { get; set; }
        public List<Discount> Discounts { set; get; }
        public List<Payment> Payments { set; get; }
    }
}
