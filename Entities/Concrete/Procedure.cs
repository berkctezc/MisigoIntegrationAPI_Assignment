using System.Collections.Generic;
using Core.Entities;
using Entities.Types;

namespace Entities.Concrete
{
    public class Procedure : IEntity
    {
        public int Id { get; set; }
        public int ModelType { get; set; }
        public string ProcName { get; set; }

        public List<Parameter> Parameters { get; set; }
    }
}
