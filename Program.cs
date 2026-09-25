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

            // Object of the new class Jobs is created

            Hobby hobby = new Hobby();
            hobby.Salary();

            Sell sell = new Sell();
            sell.Salary();
        }
    }
}
