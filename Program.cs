using Övningar___OOP_Grund___Github.Classes;

namespace Övningar___OOP_Grund___Github
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, New Person!");

            // Object of the class person is created

            Person Palash = new Person();

            Palash.RunPerson();


            // Object of the new class gender
            Gender newgender = new Gender();
            newgender.RunGender();
            newgender.Correct();
        }
    }
}
