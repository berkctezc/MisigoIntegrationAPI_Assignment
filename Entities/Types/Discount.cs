using Core.Entities;
using System;

namespace Entities.Types
{
    public class Discount:IEntity
    {
        public int Id { get; set; }
        public string DiscountTypeCode { get; set; }
        public Double Value { get; set; }
        public byte DiscountReasonCode { get; set; }
        public bool IsPercentage { get; set; }
    }
}