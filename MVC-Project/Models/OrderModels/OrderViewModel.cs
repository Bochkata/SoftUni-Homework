using System.ComponentModel.DataAnnotations;

namespace Industrial_Design.Models.OrderModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string OrderDate { get; set; } = null!;

        public string FinishDate { get; set; } = null!;

        public string Information { get; set; } = null!;

        public int Price { get; set; }

    }
}
