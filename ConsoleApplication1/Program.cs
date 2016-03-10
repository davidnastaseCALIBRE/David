using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            int a = Int32.Parse(Console.ReadLine());
            List<int> holder = DavidMath.Prime.primeFactors(a);

            Console.WriteLine("The Prime Factors of " + a + " are:");

            foreach (int x in holder)
                Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}