namespace ShoppingListApp.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<ProductNote> ProductNotes { get; set; }
                  = new List<ProductNote>();

    }
}
