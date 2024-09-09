using Webshop_Candy.Models;

namespace Webshop_Candy.Service
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);

    }
}
