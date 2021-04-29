using Core.Entities;

namespace Entities.Types
{
    public class SumLine:IEntity
    {
        public int Id { get; set; }
        public string LotBarcode { get; set; }
        public float Qty1 { get; set; }
    }
}