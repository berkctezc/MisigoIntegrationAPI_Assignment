using Core.Entities;

namespace Entities.Types
{
    public class Communication:IEntity
    {
        public string CommunicationTypeCode { get; set; }
        public string CommAddress { get; set; }
    }
}