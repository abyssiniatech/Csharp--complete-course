using System;
using System.Collections.Generic;

namespace Name
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Welcome to C# programming!");

            // variables in c#
            int num1 = 12;
            Console.WriteLine("The value of num1 is: " + num1);
            string name = "John";
            Console.WriteLine("The name is: " + name);

            // boolean
            bool isTrue = true;
            Console.WriteLine("The value of isTrue is: " + isTrue);

            // char
            char grade = 'A';
            Console.WriteLine("The grade is: " + grade);

            // constants
            const double pi = 3.14;
            Console.WriteLine("The value of pi is: " + pi);

            // data types in c#
            int ages = 25;
            double salary = 50000.50;
            string city = "New York";
            Console.WriteLine("Ages: " + ages);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("City: " + city);

            // operators in c#
            int a = 10;
            int b = 5;
            // arithmetic operators
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a / b = " + (a / b));
            // comparison operators
            Console.WriteLine("a == b: " + (a == b));
            Console.WriteLine("a != b: " + (a != b));
            Console.WriteLine("a > b: " + (a > b));
            Console.WriteLine("a < b: " + (a < b));
            // logical operators
            bool isAdult = ages >= 18;
            Console.WriteLine("Is adult: " + isAdult);
            bool isEmployed = true;
            Console.WriteLine("Is employed: " + isEmployed);

            // control flow in c#
            int myage = 20;
            string names = "Surafel";

            if (myage >= 18)
            {
                Console.WriteLine(names + " is an adult.");
            }
            else
            {
                Console.WriteLine(names + " is a minor.");
            }

            // loops in c#
            // for loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Iteration: " + i);
            }

            // while loop
            int count = 0;
            while (count < 5)
            {
                Console.WriteLine("Count: " + count);
                count++;
            }

            // do-while loop
            int number = 0;
            do
            {
                Console.WriteLine("Number: " + number);
                number++;
            } while (number < 5);

            // arrays in c#
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("First number: " + numbers[0]);
            Console.WriteLine("Second number: " + numbers[1]);

            // multi-dimensional array
            int[,] matrix = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            Console.WriteLine("Matrix element [0,0]: " + matrix[0, 0]);
            Console.WriteLine("Matrix element [1,1]: " + matrix[1, 1]);

            // functions in c#
            int result = Add(5, 10);
            Console.WriteLine("The sum is: " + result);

            // classes and objects in c#
            Person person1 = new Person { Name = "Alice", Age = 30 };
            person1.Introduce();

            // list in c#
            List<string> namesList = new List<string>();
            namesList.Add("Alice");
            namesList.Add("Bob");
            Console.WriteLine("Names in the list:");
            foreach (string personName in namesList)
            {
                Console.WriteLine(personName);
            }
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
    }

    class Person
    {
        public required string Name { get; set; }
        public int Age { get; set; }

        public void Introduce()
        {
            Console.WriteLine("Hello, my name is " + Name + " and I am " + Age + " years old.");
        }
    }
}


// list of c# keywords
// abstract, as, base, bool, break, byte, case, catch, char, checked, class, const, continue,
// decimal, default, delegate, do, double, else, enum, event, explicit, extern, false,
// finally, fixed, float, for, foreach, goto, if, implicit, in, int, interface, internal,
// is, lock, long, namespace, new, null, object, operator, out, override, params,
// private, protected, public, readonly, ref, return, sbyte, sealed, short, sizeof,
// stackalloc, static, string, struct, switch, this, throw, true, try, typeof,
// uint, ulong, unchecked, unsafe, ushort, using, virtual, void, volatile, while





