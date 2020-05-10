using System.Collections.Generic;
using WebStore.DomainNew.Entities;
using WebStore.Models;

namespace WebStore.Infrastructure.Interface
{
    public interface IOrdersService
    {
        IEnumerable<Order> GetUserOrders(string userName);
        Order GetOrderById(int id);

        Order CreateOrder(OrderViewModel orderModel,
            CartViewModel transformCart, string userName);
    }
}