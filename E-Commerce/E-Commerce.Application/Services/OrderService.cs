using E_Commerce.Applications.Contracts;
using E_Commerce.Domain.Enums;
using E_Commerce.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E_Commerce.Applications.Services
{
    public class OrderService
    {
        IOrderRepository _iOrderepository { set; get; }
        
        public OrderService(IOrderRepository iOrderepository)
        {
            _iOrderepository = iOrderepository;
        }
        public Order CreateOrder(Order order)
        {
            if (IsValidOrder(order))
            {
                _iOrderepository.Create(order);
                return order;
            }
            return null;
        }

        public IQueryable<Order> GetAllOrders()
        {
          var orders= _iOrderepository.GetAll().Include(e=>e.OrderDetails);
            return orders;
        }

        public Order GetOrderById(int orderId)
        {
            
            return _iOrderepository.GetById(orderId);
        }


        public bool ChangeTheStautsOfOrder(int orderId, OrderState newStatus)
        {
            if (orderId != null)
            {
                _iOrderepository.ChangeStatus(orderId,newStatus);
                return true;
            }
            return false;
        }

        public bool DeleteOrder(int orderId)
        {
            Order order = _iOrderepository.GetById(orderId);

            if (order != null)
            {
                _iOrderepository.Delete(order,orderId);
                return true;
            }
            return false;
        }

        private bool IsValidOrder(Order order)
        {
            if (order.OrderDetails.Count <= 0)
                return false;
            

            return true; 
        }
    }

    
}
