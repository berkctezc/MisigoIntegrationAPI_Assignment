using System;
using System.Collections.Generic;
using Core.Entities;
using Entities.Abstract;
using Entities.Types;

namespace Entities.Concrete
{
    public class RetailOrder : IEntity, IOrder
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
        public List<Line> Lines { get; set; }
        public List<SumLine> SumLines { get; set; }
        public OrderViaInternetInfo OrdersViaInternetInfo { get; set; }
        public List<Discount> Discounts { get; set; }
        public List<Payment> Payments { get; set; }
    }
}
