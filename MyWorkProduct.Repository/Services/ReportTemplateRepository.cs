using Microsoft.EntityFrameworkCore;
using MyWorkProduct.DataAccess.Context;
using MyWorkProduct.DataAccess.Models;
using MyWorkProduct.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkProduct.Repository.Services
{
    public class ReportTemplateRepository : BaseRepository<ReportTemplate>, IReportTemplateRepository
    {
        public ReportTemplateRepository(MyWorkProductDbContext context) : base(context)
        {

        }
        public override Task<bool> Add(ReportTemplate entity)
        {
            return base.Add(entity);
        }

        public override Task<bool> Delete(Guid id)
        {
            return base.Delete(id);
        }

        public override Task<IEnumerable<ReportTemplate>> Find(Expression<Func<ReportTemplate, bool>> predicate)
        {
            return base.Find(predicate);
        }

        public override async Task<IEnumerable<ReportTemplate>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public override async Task<ReportTemplate> GetById(int id)
        {
            return await _dbSet.Where(prop => prop.ReportTemplateId == id).SingleOrDefaultAsync();
        }

        public override Task<bool> Upsert(ReportTemplate entity)
        {
            return base.Upsert(entity);
        }
    }
}
