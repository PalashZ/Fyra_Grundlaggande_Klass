
namespace Övningar___OOP_Grund___Github.Classes
{
    // This is the class for Height and weight, we are going to implemnt polymorphism with help of the Person class
    public class Height_and_weight : Person
    {

        // Attributes for the class
        public string Height;

        public string Weight;


        // This is a virtual void for the class, This metod help us to overwrite.
        public virtual void Runindex()
        {
            Console.WriteLine($" Your Height is {Height}. Your Weight is {Weight} ");
        }
    }
}
