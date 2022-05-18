using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWorkProduct.DataAccess.Models;

namespace MyWorkProduct.Repository.Interface
{
    public interface IUserRepository: IBaseRepository<User>
    {
        Task<User> GetUserByUsername(string username);
    }
}
