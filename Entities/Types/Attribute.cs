using Core.Entities;

namespace Entities.Types
{
    public class Attribute:IEntity
    {
        public int AttributeTypeCode { get; set; }
        public string AttributeCode { get; set; }
    }
}