using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingListApp.Data
{
    public class ProductNote
    {
        public int Id { get; set; }
        public string Content { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
