using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSourceControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a greeting");
            string greeting = Console.ReadLine();
            Console.WriteLine(greeting);

            Console.WriteLine("Change one.");

            
            Console.ReadKey();
        }
    }
}
