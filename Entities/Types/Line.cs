namespace Entities.Types
{
    public class Line
    {
        public string ColorCode { get; set; }
        public string ItemCode { get; set; }
        public string ItemDim1Code { get; set; }
        public string UsedBarcode { get; set; }
        public float Qty1 { get; set; }
        public float LDisRate1 { get; set; }
        public string LineDescription { get; set; }
        public decimal PriceVI { get; set; }
    }
}