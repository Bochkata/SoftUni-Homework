namespace Industrial_Design.Models.OrderModels
{
    public class OrdersAllViewModel
    {
        public IEnumerable<OrderViewModel> Orders { get; set; } = new List<OrderViewModel>();
    }
}
