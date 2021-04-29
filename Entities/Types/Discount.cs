using Core.Entities;

namespace Entities.Types
{
    public class Discount:IEntity
    {
        public int Id { get; set; }
        public string DiscountTypeCode { get; set; }
        public float Value { get; set; }
        public int DiscountReasonCode { get; set; }
        public bool IsPercentage { get; set; }
    }
}