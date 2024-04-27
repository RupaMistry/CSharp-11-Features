using CSharpFeatures.Models;

namespace CSharpFeatures.Patterns
{
    public partial class Patterns
    { 
        public Patterns(InventoryService inventoryService)
        {
            //  2. Null checking:
            if (inventoryService is null)
                throw new ArgumentNullException(nameof(inventoryService));

            _inventoryService = inventoryService;
        }

        public static void Constant()
        {
            //1. Checking enums:
            LogLevel level = LogLevel.Warning;

            if (level is LogLevel.Warning)
            {
                Console.WriteLine("Log level is set to Warning");
            }
        }
    }
}