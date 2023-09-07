namespace CSharpFeatures
{
    internal static class RawStringLiterals
    {
        internal static void Feature()
        {
            // This raw string literal will output exactly what is written between the triple quotes,
            // without interpreting any escape sequences
            string genericEmailText = """
             Dear User,

             We have successfully received your "Address Correction" request.
    
             Thank you for your email.

             Regard's,
    
             Team.
            """;

            Console.WriteLine(genericEmailText);

            // You can also combine raw string literals with interpolated strings to embed expressions
            // or variables in your strings.
            var userName = "Rupa Mistry";
            var welcomeMsg = $"""" Hello {userName}, Welcome to "Microsoft's Learning Event"! """";

            Console.WriteLine(welcomeMsg);
        }
    }
}
