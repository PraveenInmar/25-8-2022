using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many records do you want....?:");
            int enter = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<enter;i++)
            {
                try
                {
                    Person p = new Person();
                    Console.WriteLine("Enter the Name:");
                    p.Name = Console.ReadLine();
                    Console.WriteLine("Enter the Age:");
                    p.Age = Convert.ToInt32(Console.ReadLine());
                    if (p.Valid())
                    {
                        Console.WriteLine("Name " + p.Name + "Age" + p.Age);
                    }
                    else
                    {
                        Console.WriteLine("invalid data");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("enter invalid data");
                }
            }
            Console.ReadLine();
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }

        public bool Valid()
        {
            if (Name.Length == 0)
            {
                return false;
            }
            if (Age > 100)
            {
                return false;
            }
            return true;
        }
    }
}
