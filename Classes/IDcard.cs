
using System.Reflection.Metadata.Ecma335;

namespace Övningar___OOP_Grund___Github.Classes
{
    public class IDcard
    {
        private string name;

        private int age;

        private string idNumber;


        public IDcard(string name, int age, string idnumber)
        {
            this.Name = name;
            this.Age = age;
            this.IdNumber = idnumber;
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public string IdNumber
        {
            get { return idNumber; }
            set { idNumber = value; }
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"ID Number: {IdNumber}");
        }
    }
}
