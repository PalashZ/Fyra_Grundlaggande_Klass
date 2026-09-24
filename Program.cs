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


            IDcard card = new IDcard("Solina Ahmed", 21, "123456789");
            card.DisplayInfo();

            card.IdNumber = "051221";
            card.DisplayInfo();
        }
    }
}
