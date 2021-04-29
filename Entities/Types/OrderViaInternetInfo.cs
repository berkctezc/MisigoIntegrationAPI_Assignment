using System;
using Core.Entities;

namespace Entities.Types
{
    public class OrderViaInternetInfo:IEntity
    {
        public int Id { get; set; }
        public string SalesURL { get; set; }
        public int PaymentTypeCode { get; set; }
        public string PaymentTypeDescription { get; set; }
        public string PaymentAgent { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime SendDate { get; set; }
    }
}