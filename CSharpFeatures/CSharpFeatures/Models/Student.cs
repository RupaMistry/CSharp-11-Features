namespace CSharpFeatures.Models
{
    public class Student
    {
        /*  To declare a Required Member:
            you use the "required" modifier on the property or field declaration.
        */
        public required int StudentID { get; init; }

        public required string FirstName { get; init; }

        public required string LastName { get; init; }

        /*  We can also use constructors to set the required members;
            but we need to mark them with the "[SetsRequiredMembers]" attribute
            to let the compiler know.
        */
        // [SetsRequiredMembers]
        // public Student(int studentID, string firstName, string lastName)
        // {
        //     StudentID = studentID;
        //     FirstName = firstName;
        //     LastName = lastName;
        // }
    }
}
