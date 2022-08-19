using System;

namespace Generics_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee<string>();
            employee.Things = new System.Collections.Generic.List<string>();

            employee.Things.Add("thing1");
            employee.Things.Add("thing2");
            employee.Things.Add("thing3");

            Employee<int> employee1 = new Employee<int>();
            employee1.Things = new System.Collections.Generic.List<int>();

            employee1.Things.Add(123);
            employee1.Things.Add(543);
            employee1.Things.Add(767473);

            foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("\n");

            foreach (int thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();

        }

    }
}
