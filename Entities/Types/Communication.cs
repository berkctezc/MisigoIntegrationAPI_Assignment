using Core.Entities;

namespace Entities.Types
{
    public class Communication:IEntity
    {
        public int Id { get; set; }
        public string CommunicationTypeCode { get; set; }
        public string CommAddress { get; set; }
    }
}