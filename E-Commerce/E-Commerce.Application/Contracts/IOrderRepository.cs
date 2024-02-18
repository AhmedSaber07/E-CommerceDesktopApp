using E_Commerce.Domain.Enums;
using E_Commerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Applications.Contracts
{
    public interface IOrderRepository: IBaseRepository<Order>
    {
        Order ChangeStatus(int id, OrderState newStatus);


    }
}
