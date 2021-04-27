using Core.Entities;

namespace Entities.Types
{
    public class ModelType:IEntity
    {
        public int Id { get; set; }
        public string ModelTypeDescription { get; set; }
    }
}
