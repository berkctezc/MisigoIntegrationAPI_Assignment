using System.Collections.Generic;
using Core.Entities;
using Entities.Types;

namespace Entities.Concrete
{
    public class Product : IEntity
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
        public List<Attribute> Attributes { get; set; }
        public List<Variant> Variants { get; set; }
    }
}
