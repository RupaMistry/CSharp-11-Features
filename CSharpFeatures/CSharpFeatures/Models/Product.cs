namespace CSharpFeatures.Models
{
    public record Product()
    {
        public decimal Price { get; set; }
        public string Region { get; set; } = string.Empty;
    }

    public class InventoryService
    {
        public void AddNewProduct(Product product)
        {
        }
    }
}
