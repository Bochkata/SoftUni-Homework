using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace IndustrialDesign.Data.Entities
{
    public class PendingOrder
    {
        public int Id { get; set; }

        [Required]
        public string OrderDate { get; set; } 

        [Required]
        public string ClientName { get; set; }
        [Required]

        public string FinishDate { get; set; }
        [Required]
        public string Information { get; set; }
        [Required]
        public int Price { get; set; }

    }
}
