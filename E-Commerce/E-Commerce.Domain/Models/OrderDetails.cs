using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Models
{
    public class OrderDetails
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        //relation 
        public Order? Order { get; set; }
        public Product? Product { get; set; }
    }
}
