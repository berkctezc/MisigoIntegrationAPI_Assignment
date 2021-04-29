using Core.Entities;

namespace Entities.Concrete
{
    public class Procedure : IEntity
    {
        public int Id { get; set; }
        public int ModelType { get; set; }
        public string ProcName { get; set; }
        public int ParametersId { get; set; }
    }
}