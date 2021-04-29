using Core.Entities;

namespace Entities.Types
{
    public class Attribute:IEntity
    {
        public int Id { get; set; }
        public int AttributeTypeCode { get; set; }
        public string AttributeCode { get; set; }
    }
}