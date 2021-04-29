using Core.Entities;

namespace Entities.Types
{
    public class Parameter:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}