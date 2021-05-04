using System;
using Core.Entities;

namespace Entities.Types
{
    public class SaleViaInternetInfo:IEntity
    {
        public int Id { get; set; }
        public string SalesURL { get; set; }
        public byte PaymentTypeCode { get; set; }
        public string PaymentTypeDescription { get; set; }
        public string PaymentAgent { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime SendDate { get; set; }
    }
}