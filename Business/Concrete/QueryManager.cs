using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Concrete
{
    public class QueryManager : IQueryService//implement operations
    {
        public IResult Add(Query query)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(Query query)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Query query)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Query>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Query> GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}