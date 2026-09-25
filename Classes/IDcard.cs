
using System.Reflection.Metadata.Ecma335;

namespace Övningar___OOP_Grund___Github.Classes
{

    // New class IDcard, This class is for encapsulation
    public class IDcard
    {

        // Private attributes of the class IDcard
        private string name;

        private int age;

        private string idNumber;

        // Public constructor of the class IDcard
        public IDcard(string name, int age, string idnumber)
        {
            this.Name = name;
            this.Age = age;
            this.IdNumber = idnumber;
        }

        // Public properties of the class IDcard
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


        // Public method of the class IDcard
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"ID Number: {IdNumber}");
        }
    }
}
