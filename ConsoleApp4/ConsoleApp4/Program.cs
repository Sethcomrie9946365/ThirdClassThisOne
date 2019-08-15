using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter your grade: ");
            float mark = float.Parse(Console.ReadLine());

            if (mark >= 90 && mark <= 100)
                Console.WriteLine("Your grade is an A!");
            else if (mark >= 80 && mark <= 89)
                Console.WriteLine("your grade is an B!");
            else if (mark >= 70 && mark <= 79)
                Console.WriteLine("your grade is a C!");
            else if (mark >= 60 && mark <= 69)
                Console.WriteLine("your grade is a D!");
            else if (mark >= 50 && mark <= 59)
                Console.WriteLine("your grade is a E!");
            else if (mark >= 40 && mark <= 49)
                Console.WriteLine("your mark is a F!");
            else if (mark >= 0 && mark <= 39)
                Console.WriteLine("your grade is a G");
            else
                Console.WriteLine("Something wrong with your grade");

            Console.ReadLine();
        }
    }
}
