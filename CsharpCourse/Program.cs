using System;
using System.Collections.Generic;
namespace Hello
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] foods = new string[5];
            foods[0] = "pizza";
            foods[1] = "pizza";
            foods[2] = "Burger";
            foods[3] = "Donat";
            foods[4] = "Firfir";
            // print foods
            foreach (var food in foods)
            {
                Console.WriteLine(food);
                Console.WriteLine(food);
            }

            Console.WriteLine("++++++++++++++");
            // list in c#
            List<string> students = new List<string>();
            students.Add("Samuel");
            students.Add("Abel");
            students.Add("Henok");
            students.Add("aster");

            // excute the lists of student in foreach method
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }


        // list of numbers 
        List<int> numbers= new List<int>();
        numbers.Add(12);
        numbers.Add(15);
        numbers.Add(14);
        numbers.Add(17);
        numbers.Add(19);
        numbers.Add(20);
      

    //   excute the numbers list 
      foreach(int val in numbers)
            {
                System.Console.WriteLine(val);
            }

            // list of frainds
            List<string> frainds= new List<string>
            {
               "abreham",
               "Samuel",
               "Sara",
               "Yeshemebet",
               "Samson",
               "Seada"
            };

            foreach (var items in frainds)
            {
                
                System.Console.WriteLine(items.Count());
            }
        }
    }
}