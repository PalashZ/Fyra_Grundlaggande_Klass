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


            // Object for the new class Height and weight

            Person Index = new Height_and_weight
            {
                weight = "195cm",
                height = "140cm"
            };

            Index.RunPerson();

            

   
        }
        
    }
}
