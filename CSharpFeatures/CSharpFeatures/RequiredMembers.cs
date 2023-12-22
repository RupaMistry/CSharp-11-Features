using CSharpFeatures.Models;

namespace CSharpFeatures
{
    internal static class RequiredMembers
    {
        internal static void Feature()
        {
            /* To resolve the Compile-Time Error:
               We can use object initializers to set the required members of the class.
            */
            var student1 = new Student()
            {

                StudentID = 1,
                FirstName = "TestFirstName",
                LastName = "TestLastName"
            };


            /* Then we can use the constructor to create a `Student` object 
               without an object initializer.
            */
            //var student = new Student(1, "TestFirstName", "TestLastName");
        }
    }
}