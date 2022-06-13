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
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected MyWorkProductDbContext _context;
        internal DbSet<T> _dbSet;
        public BaseRepository(MyWorkProductDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public async virtual Task<T> Add(T entity)
        {
            _dbSet.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async virtual Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> Upsert(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
