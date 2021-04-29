using System;
using Core.Entities;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class WholesaleOrder : IEntity, IOrder
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
        public int LinesId { get; set; }
        public int OrdersViaInternetInfoId { get; set; }
        public int DiscountsId { set; get; }
        public int PaymentsId { set; get; }
    }
}