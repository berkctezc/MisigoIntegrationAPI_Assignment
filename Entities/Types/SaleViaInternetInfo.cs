using System;

namespace Entities.Types
{
    public class SaleViaInternetInfo
    {
        public string SalesURL { get; set; }
        public int PaymentTypeCode { get; set; }
        public string PaymentTypeDescription { get; set; }
        public string PaymentAgent { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime SendDate { get; set; }

    }
}