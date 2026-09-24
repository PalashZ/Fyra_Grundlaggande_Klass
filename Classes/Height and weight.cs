
namespace Övningar___OOP_Grund___Github.Classes
{
    public class Height_and_weight : Person
    {
        public string Height;

        public string Weight;


        public virtual void Runindex()
        {
            Console.WriteLine($" Your Height is {Height}. Your Weight is {Weight} ");
        }
    }
}
