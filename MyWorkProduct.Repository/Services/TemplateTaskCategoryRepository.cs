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
    public class TemplateTaskCategoryRepository : BaseRepository<TemplateTaskCategory>, ITemplateTaskCategoryRepository
    {
        public TemplateTaskCategoryRepository(MyWorkProductDbContext context) : base(context)
        {

        }
        public override Task<bool> Add(TemplateTaskCategory entity)
        {
            return base.Add(entity);
        }

        public override Task<bool> Delete(Guid id)
        {
            return base.Delete(id);
        }

        public override Task<IEnumerable<TemplateTaskCategory>> Find(Expression<Func<TemplateTaskCategory, bool>> predicate)
        {
            return base.Find(predicate);
        }

        public async override Task<IEnumerable<TemplateTaskCategory>> GetAll()
        {
            return await _dbSet.Include(e => e.CategoryType).ToListAsync();
        }

        public override Task<TemplateTaskCategory> GetById(int id)
        {
            return base.GetById(id);
        }

        public override Task<bool> Upsert(TemplateTaskCategory entity)
        {
            return base.Upsert(entity);
        }
    }
}
