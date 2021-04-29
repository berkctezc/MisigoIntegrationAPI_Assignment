using System;
using Core.Entities;

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
        public int LinesId { get; set; }
        public int OrdersViaInternetInfoId { get; set; }
        public int DiscountsId { set; get; }
        public int PaymentsId { set; get; }
    }
}
