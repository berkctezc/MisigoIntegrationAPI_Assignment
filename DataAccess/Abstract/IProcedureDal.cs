using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IProcedureDal : IEntityRepository<Procedure>
    {
        List<ProcedureDto> GetProcedureDetails(Expression<Func<Procedure, bool>> filter = null);
        ProcedureDto GetProcedureDetailsById(Expression<Func<Procedure, bool>> filter = null);
    }
}