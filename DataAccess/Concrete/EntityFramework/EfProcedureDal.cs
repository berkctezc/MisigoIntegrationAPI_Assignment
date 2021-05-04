using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProcedureDal : EfEntityRepositoryBase<Procedure, EntegrasyonDbContext>, IProcedureDal
    {
        public List<ProcedureDto> GetProcedureDetails(Expression<Func<Procedure, bool>> filter = null)
        {
            using (EntegrasyonDbContext context = new EntegrasyonDbContext())
            {
                var result =
                    from procedure in context.Procedures
                    join parameter in context.Parameters
                        on procedure.ParametersId equals parameter.Id
                    select new ProcedureDto
                    {
                        Id = procedure.Id,
                        ModelType = procedure.ModelType,
                        ProcName = procedure.ProcName,
                        //
                        ParametersId = parameter.Id,
                        ParametersName = parameter.Name,
                        ParametersValue = parameter.Value
                    };
                return result.ToList();
            }
        }

        public ProcedureDto GetProcedureDetailsById(Expression<Func<Procedure, bool>> filter)
        {
            using (EntegrasyonDbContext context = new EntegrasyonDbContext())
            {
                var result =
                    from procedure in filter is null ? context.Procedures : context.Procedures.Where(filter)
                    join parameter in context.Parameters
                        on procedure.ParametersId equals parameter.Id
                    select new ProcedureDto
                    {
                        Id = procedure.Id,
                        ModelType = procedure.ModelType,
                        ProcName = procedure.ProcName,
                        //
                        ParametersId = parameter.Id,
                        ParametersName = parameter.Name,
                        ParametersValue = parameter.Value
                    };
                return result.SingleOrDefault();
            }
        }
    }
}