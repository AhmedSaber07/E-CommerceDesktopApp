using E_Commerce.Application.Contracts;
using E_Commerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Services
{
    public class UserService
    {
        IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }
        public User UserRegister(User user)
        {
            if (user is not null)
            {
                var _user = _userRepository.Create(user);
                _userRepository.Complete();
                return _user;
            }
            return null;
        }
        public User UpdateUser(User user)
        {
            if (user is not null)
            {
                var _user = _userRepository.Update(user);
                _userRepository.Complete();
                return _user;
            }
            return null;
        }
        public bool DeleteUser(User user)
        {
            if (user is not null)
            {
                bool _user = _userRepository.Delete(user);
                _userRepository.Complete();
                return _user;
            }
            return false;
        }
        public IQueryable<User> GetProducts()
        {
            return _userRepository.GetAll();
        }
        public User GetProduct(int id)
        {
            if (id != 0)
            {
                return _userRepository.GetById(id);
            }
            return null;
        }
        //public IQueryable<User> SearchByName(string userName)
        //{
        //    if (userName is not null)
        //    {
        //        return _userRepository.SearchByName(userName);
        //    }
        //    return null;
        //}
        public User Login(string Email,string passwrd)
        {
            return _userRepository.Login(Email, passwrd);
        } 
    }
}
