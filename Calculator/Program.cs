using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //display the m value and take m input from the user
            Console.WriteLine("enter the m vlaue");
            int m = Convert.ToInt32(Console.ReadLine());

            //dispay the n vlaue and take n input from the user
            Console.WriteLine("enter the n value");
            int n = Convert.ToInt32(Console.ReadLine());

            //dispay the operation and user to enter the operation
            Console.WriteLine("enter the operation:");
            string operation = Console.ReadLine();

            //storing result
            int result = 0;

            if(operation == "+")
            {
                result= m + n;
            }
            else if(operation =="-")
            {
                result = m - n;
            }
            else if (operation == "*")
            {
                result = m * n;
            }
            else if (operation == "/")
            {
                result = m / n;
            }
            else if (operation == "%")
            {
                result = m % n;
            }
            Console.WriteLine("result is....>"+result);
        }
    }
}
