using CSharpFeatures.Models;

namespace CSharpFeatures.Patterns
{
    public partial class Patterns
    {
        private readonly InventoryService _inventoryService;

        public Patterns() => _inventoryService = new();

        public void Logical()
        {
            // Conjunctive and pattern:
            int age = 20;

            if (age is >= 18 and <= 65)
            {
                Console.WriteLine("Eligible for voting");
            }

            // Disjunctive or pattern:
            string status = "active";
            bool isAdmin = true;

            if (status is ("active" or "pending") && isAdmin)
            {
                Console.WriteLine("Authorized user with active or pending status");
            }

            //Negation not pattern: allows you to negate a pattern, checking if an expression doesn’t match a specific condition
            // The following example shows how you can negate a constant null pattern to check if an expression is non-null:
            var product = new Product(); ;

            if (product is not null)
            {
                _inventoryService.AddNewProduct(product);

                // Combining property pattern with logical pattern
                if (product is { Region: "India" } && product.Price > 1000)
                {
                    Console.WriteLine("Product is eligible for discount.");
                }
            }
        } 
    }
}