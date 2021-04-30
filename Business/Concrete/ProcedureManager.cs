using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProcedureManager : IProcedureService//implement operations
    {
        public IResult Add(Procedure procedure)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(Procedure procedure)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Procedure procedure)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Procedure>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Procedure> GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}