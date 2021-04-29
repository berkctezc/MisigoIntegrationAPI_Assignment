using Core.Entities;

namespace Entities.DTOs
{
    public class ProcedureDto:IDto
    {
        public int Id { get; set; }
        public int ModelType { get; set; }
        public string ProcName { get; set; }
        //
        public int ParametersId { get; set; }
        public string ParametersName { get; set; }
        public string ParametersValue { get; set; }
    }
}
