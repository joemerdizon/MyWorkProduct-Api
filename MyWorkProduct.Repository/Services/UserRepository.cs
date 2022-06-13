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
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(MyWorkProductDbContext context) : base(context)
        {

        }
        public override Task<User> Add(User entity)
        {
            return base.Add(entity);
        }

        public override Task<bool> Delete(Guid id)
        {
            return base.Delete(id);
        }

        public override Task<IEnumerable<User>> Find(Expression<Func<User, bool>> predicate)
        {
            return base.Find(predicate);
        }

        public override async Task<IEnumerable<User>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public override Task<User> GetById(int id)
        {
            return base.GetById(id);
        }

        public async Task<User> GetUserByUsername(string username)
        {
            return await _dbSet.Include(e => e.Role)
                .SingleOrDefaultAsync(x => x.Username == username);
        }

        public override Task<bool> Upsert(User entity)
        {
            return base.Upsert(entity);
        }
    }
}
