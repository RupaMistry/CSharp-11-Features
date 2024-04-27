namespace CSharpFeatures.Patterns
{
    public partial class Patterns
    {

        // 1. Declaration Simple type check and variable assignment: 
        public static void Declaration()
        {
            //In this example, the "is" keyword checks if jobTitle is of type "string".
            //If it is, the variable title is declared and assigned the value of jobTitle simultaneously.

            object jobTitle = ".NET Technical Lead";

            if (jobTitle is string title)
            {
                Console.WriteLine(title.ToUpper());
            }
        }
    }
}