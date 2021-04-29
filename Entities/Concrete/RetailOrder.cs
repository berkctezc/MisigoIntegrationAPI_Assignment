using System;
using Core.Entities;
using Entities.Abstract;

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
        public int LinesId { get; set; }
        public int SumLinesId { get; set; }
        public int OrdersViaInternetInfoId { get; set; }
        public int DiscountsId { get; set; }
        public int PaymentsId { get; set; }
    }
}
