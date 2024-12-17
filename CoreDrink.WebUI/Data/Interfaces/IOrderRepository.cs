using CoreDrink.WebUI.Data.Models;

namespace CoreDrink.WebUI.Data.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
