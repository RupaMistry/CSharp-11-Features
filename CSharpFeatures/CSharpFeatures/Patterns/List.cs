namespace CSharpFeatures.Patterns
{
    public partial class Patterns
    {
        public static void List()
        {
            //1. Matching exact list elements:
            List<int> numbers = [7, 8, 9];

            // The order and values must be identical for a successful match.
            if (numbers is [7, 8, 9])
            {
                Console.WriteLine("List matches exactly: 7, 8, 9");
            }

            // 2. Matching with wildcards:
            List<string> colors = ["green", "white","blue" ];

            //Here, the wildcard _ represents any value at that position. 
            if (colors is ["green", _, "blue"])
            {
                Console.WriteLine("List starts with 'green' and ends with 'blue'");
            }

            //3. Matching with variable assignment:
            List<string> fruits = [ "mango", "apple", "banana" ];

            // This example uses variable designation within the list pattern. 
            // If the match succeeds, the first element is assigned to firstFruit and the second to secondFruit.
            if (fruits is [var firstFruit, var secondFruit])
            {
                Console.WriteLine($"First fruit: {firstFruit}, Second fruit: {secondFruit}");
            }
        }
    }
}
