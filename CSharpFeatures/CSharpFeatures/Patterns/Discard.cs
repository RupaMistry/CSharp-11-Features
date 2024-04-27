namespace CSharpFeatures.Patterns
{
    public partial class Patterns
    {
        private Tuple<int, string> GetServerError()
        {
            return new(12, "Remote service is unavailable.");
        }

        public void Discard()
        {
            //1. Avoiding first element during tuple deconstruction
            var (_, errorDetails) = GetServerError();

            if (!string.IsNullOrEmpty(errorDetails))
                Console.WriteLine($"Error: {errorDetails}"); 
        }

        //2. Handling null and any integer value that doesn't have the corresponding member in the enum
        private decimal GetDiscountForWeekend(DayOfWeek? dayOfWeek) => dayOfWeek switch
        { 
            DayOfWeek.Friday => 5.0m,
            DayOfWeek.Saturday => 10.5m,
            DayOfWeek.Sunday => 10.0m,
            _ => 0.0m,
        };
    } 
}
