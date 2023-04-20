using Industrial_Design.Models.OrderModels;

namespace Industrial_Design.Contracts
{
    public interface IOrderService
    {
        Task AddOrderAsync(OrderFormModel orderFormModel);
        Task<OrdersAllViewModel> GetAllOrdersAsync();

    }
}
