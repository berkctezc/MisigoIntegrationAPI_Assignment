using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProcedureService
    {
        IResult Add(Procedure procedure);
        IResult Delete(Procedure procedure);
        IResult Update(Procedure procedure);
        IDataResult<List<Procedure>> GetAll();
        IDataResult<Procedure> GetById(int id);
    }
}
