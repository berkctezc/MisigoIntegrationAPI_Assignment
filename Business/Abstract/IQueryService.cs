using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IQueryService
    {
        IResult Add(Query query);
        IResult Delete(Query query);
        IResult Update(Query query);
        IDataResult<List<Query>> GetAll();
        IDataResult<Query> GetById(int id);
    }
}