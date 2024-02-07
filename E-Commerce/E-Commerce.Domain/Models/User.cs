using E_Commerce.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Models
{
    public class User
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber  { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public UserType UserType { get; set; }
        
        //Relation
        public List<Order>? Orders { get; set; }
    }
}
