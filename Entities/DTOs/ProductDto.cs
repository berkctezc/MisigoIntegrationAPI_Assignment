using Core.Entities;

namespace Entities.DTOs
{
    public class ProductDto:IDto
    {
        public int Id { get; set; }
        public int ModelType { get; set; }
        public int ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public int ItemDimTypeCode { get; set; }
        public string UnitOfMeasureCode1 { get; set; }
        public string ItemTaxGrCode { get; set; }
        public int ProductHierarchyID { get; set; }
        public bool UsePOS { get; set; }
        public bool UseStore { get; set; }
        public bool UseInternet { get; set; }
        //
        public int AttributesId { get; set; }
        public int AttributeTypeCode { get; set; }
        public string AttributeCode { get; set; }
        //
        public int VariantsId { get; set; }
        public string ColorCode { get; set; }
        public string ItemDim1Code { get; set; }
        //
    }
}
