using Core.Entities;

namespace Entities.Concrete
{
    public class Query : IEntity
    {
        public int Id { get; set; }
        public int ModelType { get; set; }
        public string QueryName { get; set; }
        public string Criteria { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }
    }
}
