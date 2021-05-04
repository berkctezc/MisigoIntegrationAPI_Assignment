using Core.Entities;
using System;

namespace Entities.Types
{
    public class SumLine:IEntity
    {
        public int Id { get; set; }
        public string LotBarcode { get; set; }
        public Double Qty1 { get; set; }
    }
}