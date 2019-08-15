using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your first name");
            string name = Console.ReadLine();

            Console.WriteLine("what is your 2nd name");
            string name2 = Console.ReadLine();

            Console.WriteLine("Hi {0} {1}", name, name2);

            Console.ReadLine();
        }
    }
}
