using Core.Entities;

namespace Entities.Concrete
{
    public class Connect:IEntity
    {
        public int Id { get; set; }
        public int ModelType { get; set; }
        public string DatabaseName { get; set; }
        public string UserGroupCode { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
