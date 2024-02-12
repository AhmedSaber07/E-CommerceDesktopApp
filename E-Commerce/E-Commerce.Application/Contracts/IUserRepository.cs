using E_Commerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Contracts
{
    public interface IUserRepository :IBaseRepository<User>
    {
        //IQueryable<User> SearchByName(string userName);
        User Login(string email, string password);

    }
}
