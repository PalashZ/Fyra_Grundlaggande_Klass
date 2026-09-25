
namespace Övningar___OOP_Grund___Github.Classes
{
    // This is a new class Jobs, this is for implementing abstract

    abstract class Jobs
    {
        public abstract void Salary();
    }

    // These classes is for making abstracion to work, it will let us implent fron the main class "Jobs"

    class Hobby : Jobs
    {

        public override void Salary()
        {
            Console.WriteLine(" Hobbys gets paid too");
        }

    }

    class Sell : Jobs
    {

        public override void Salary()
        {
            Console.WriteLine("Selling stuff get you paid");
        }

    }

}
