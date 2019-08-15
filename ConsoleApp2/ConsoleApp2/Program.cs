using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a different number: ")
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
                Console.WriteLine("The numbers are equal");
            else if (num1 < num2)
                Console.WriteLine("{1} is greater than {2}", num1, num2);
            else Console.WriteLine("{2} is greater than {1}", num1, num2);

            Console.ReadLine();

        }
    }
}
