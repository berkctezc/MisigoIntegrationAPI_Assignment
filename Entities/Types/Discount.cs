namespace Entities.Types
{
    public class Discount
    {
        public string DiscountTypeCode { get; set; }
        public float Value { get; set; }
        public int DiscountReasonCode { get; set; }
        public bool IsPercentage { get; set; }
    }
}