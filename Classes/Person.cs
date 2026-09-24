
namespace Övningar___OOP_Grund___Github.Classes
{
    public class Person
    {
        // Attributes of the class Person
        public string name;

        public int age;

        // Method of the class Person
        public void RunPerson()
        { 
        Console.WriteLine("Enter your name: ");
         name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello {name}, you are {age} years old.");
        }
    }
}
