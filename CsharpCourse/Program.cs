
using System;

namespace Hello
{
    class Program
    {
        public static void Main(string[] args)
        {
            Animal animal = new Animal(12, "surafel Mmengist");
            Console.WriteLine($"My name is {animal.Name}");
        }
    }


    public class Animal
    {
        private int age;
        private string name;

        public Animal(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }
}





