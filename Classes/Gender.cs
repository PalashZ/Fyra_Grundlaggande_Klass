
namespace Övningar___OOP_Grund___Github.Classes
{
    // Inheritance for gender
    public class Gender : Person
    {

        // Attributes for Gender 
        public string Man;

        public string Woman;


        // Here is the metod for new version on person that is only for GENDER
        public new void RunGender()
        {
            Console.WriteLine("Enter your gender (Man/Woman): ");
            string genderInput = Console.ReadLine();
            if (genderInput.Equals("Man", StringComparison.OrdinalIgnoreCase))
            {
                Man = "Man";
                Console.WriteLine($"You are a {Man}.");
            }
            else if (genderInput.Equals("Woman", StringComparison.OrdinalIgnoreCase))
            {
                Woman = "Woman";
                Console.WriteLine($"You are a {Woman}.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'Man' or 'Woman'.");
            }
        }

        // Here is another new metod for GENDERs
        public void Correct()
        {
            Console.WriteLine("Correct Answer");
        }

    }



}