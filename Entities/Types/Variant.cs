using Core.Entities;

namespace Entities.Types
{
    public class Variant : IEntity
    {
        public int Id { get; set; }
        public string ColorCode { get; set; }
        public string ItemDim1Code { get; set; }
    }

}