using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class QueryManager : IQueryService
    {
        private readonly IQueryDal _queryDal;

        public QueryManager(IQueryDal queryDal)
        {
            _queryDal = queryDal;
        }

        [CacheRemoveAspect("IQueryService.Get")]
        public IResult Add(Query query)
        {
            _queryDal.Add(query);
            return new SuccessResult(Messages.QueryAdded);
        }

        [CacheRemoveAspect("IQueryService.Get")]
        public IResult Delete(Query query)
        {
            _queryDal.Delete(query);
            return new SuccessResult(Messages.QueryDeleted);
        }

        [CacheRemoveAspect("IQueryService.Get")]
        public IResult Update(Query query)
        {
            _queryDal.Update(query);
            return new SuccessResult(Messages.QueryUpdated);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Query>> GetAll()
        {
            return new SuccessDataResult<List<Query>>(_queryDal.GetAll(), Messages.QueriesListed);
        }

        [CacheAspect]
        public IDataResult<Query> GetById(int id)
        {
            return new SuccessDataResult<Query>(_queryDal.Get(q => q.Id == id));
        }
    }
}