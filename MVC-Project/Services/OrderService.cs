using Industrial_Design.Contracts;
using Industrial_Design.Models.OrderModels;
using IndustrialDesign.Data;
using IndustrialDesign.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace GameTracker.Services
{
    public class OrderService : IOrderService 
    {
        private readonly IndustrialDesignDbContext _industrialDesignDbContext;
        public OrderService(IndustrialDesignDbContext idustrialDesignDbContext)
        {
            _industrialDesignDbContext = idustrialDesignDbContext;
        }

        public async Task AddOrderAsync(OrderFormModel orderFormModel)
        {
            PendingOrder pendingOrder = new PendingOrder()
            {
                ClientName = orderFormModel.ClientName,
                OrderDate = orderFormModel.OrderDate,
                FinishDate = orderFormModel.FinishDate,
                Information = orderFormModel.Information,
                Price = orderFormModel.Price
            };
            await _industrialDesignDbContext.PendingOrders.AddAsync(pendingOrder);
            await _industrialDesignDbContext.SaveChangesAsync();
        }       
        public async Task<OrdersAllViewModel> GetAllOrdersAsync()
        {
            List<PendingOrder> pendingOrders = await _industrialDesignDbContext.PendingOrders.ToListAsync();
            return new OrdersAllViewModel()
            {
                Orders = pendingOrders.Select(PO => new OrderViewModel()
                {
                    Id = PO.Id,
                    ClientName = PO.ClientName,
                    OrderDate = PO.OrderDate,
                    FinishDate=PO.FinishDate,
                    Information=PO.Information,
                    Price=PO.Price
                })
            };
        }
    }
}
