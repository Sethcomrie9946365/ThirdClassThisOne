using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another whole number ");
            double num2 = double.Parse(Console.ReadLine());

            double result;

            result = num1 + num2;              
            Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
            result = num1 - num2;
            Console.WriteLine("{0} - {1} = {2}", num1, num2, result);
            result = num1 * num2;
            Console.WriteLine("{0} * {1} = {2}", num1, num2, result);
            result = num1 / num2;
            Console.WriteLine("{0} / {1} = {2}", num1, num2, result);


            Console.ReadLine();
        }
    }
}
