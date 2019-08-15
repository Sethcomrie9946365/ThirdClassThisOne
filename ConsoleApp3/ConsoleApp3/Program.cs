using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a different number: ");
            int num2 = int.Parse(Console.ReadLine());

            if(num1 > num2)
                Console.WriteLine("the first number {0} is greater than {1}", num1, num2);

            else if(num2 > num1)
                Console.WriteLine("the 2nd number {1} is greater than the first {0}", num1, num2);

            else Console.WriteLine("Numbers are equal", num1, num2);

            Console.ReadLine();

        }
    }
}
