using E_Commerce.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Dtos
{
    public class DisplayOrderDto
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public OrderState OrderState { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal FinalPrice { get; set; }
    }
}
