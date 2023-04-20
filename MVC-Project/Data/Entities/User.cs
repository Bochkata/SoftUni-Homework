using Microsoft.AspNetCore.Identity;

namespace IndustrialDesign.Data.Entities
{
    public class User : IdentityUser
    {
        public List<FinishedOrder> FinishedOrders { get; set; } = new List<FinishedOrder>();
        public List<PendingOrder> PendingOrders { get; set; } = new List<PendingOrder>();
    }
}
