using CSharpFeatures.Models;

namespace CSharpFeatures.Patterns
{
    public partial class Patterns
    {
        // 2. Pattern matching with properties:
        public static void Property()
        {
            Employee employee = new(25, "Joe");

            // The declaration pattern checks if object is a Employee instance with specific property values.
            if (employee is { Age: 25, Name: "Joe" })
                Console.WriteLine("Matched employee details");
            else
                Console.WriteLine("No employee record found.");
        }
    }
}