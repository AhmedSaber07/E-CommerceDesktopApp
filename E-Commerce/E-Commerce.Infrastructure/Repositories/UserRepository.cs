using E_Commerce.Application.Contracts;
using E_Commerce.Domain.Models;
using E_Commerce.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User> ,IUserRepository
    {
        private ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context) : base(context) 
        {
            _context = context;
        }

        public User Login(string email, string password)
        {
           return _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        public IQueryable<User> SearchByName(string userName)
        {
            return _context.Users.Where(s => s.Name == userName);
        }
    }
}
