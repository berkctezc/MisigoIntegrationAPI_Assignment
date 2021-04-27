using System;
using System.Collections.Generic;
using Core.Entities;
using Entities.Types;

namespace Entities.Abstract
{
    public interface IOrder:IEntity
    {
        public int Id { get; set; }
        public int ModelType { get; set; }
        public string CustomerCode { get; set; }
        public string OfficeCode { get; set; }
        public string ShipmentMethodCode { get; set; }
        public DateTime OrderDate { get; set; }
        public string IsCompleted { get; set; }
        public bool IsSalesViaInternet { get; set; }
        public string DocumentNumber { get; set; }
        public string Description { get; set; }
        public List<Line> Lines { get; set; }
        public OrderViaInternetInfo OrdersViaInternetInfo { get; set; }
        public List<Discount> Discounts { set; get; }
        public List<Payment> Payments { set; get; }
    }
}
