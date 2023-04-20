using System.ComponentModel.DataAnnotations;


namespace Industrial_Design.Models.OrderModels
{
    public class OrderFormModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string ClientName { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string OrderDate { get; set; } = null!;

        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string FinishDate { get; set; } = null!;


        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string Information { get; set; } = null!;


        [Required]
        public int Price { get; set; }

    }
}
