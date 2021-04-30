using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProcedureService
    {
        IResult Add(Procedure procedure);
        IResult Delete(Procedure procedure);
        IResult Update(Procedure procedure);
        IDataResult<List<Procedure>> GetAll();
        IDataResult<List<ProcedureDto>> GetProcedureDetails();
        IDataResult<Procedure> GetById(int id);
        IDataResult<ProcedureDto> GetProcedureDetailsById(int id);
    }
}