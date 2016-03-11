using System;
using System.Collections.Generic;

namespace ConsoleApplication1{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter a number :");
            int a = Int32.Parse(Console.ReadLine());
            List<int> holder = DavidMath.Prime.PrimeFactors(a);

            Console.WriteLine("The Prime Factors of " + a + " are:");

            foreach (int x in holder)
                Console.WriteLine(x);

            Console.ReadKey();

            Console.WriteLine("How many numbers should we collatz?");
            a = Int32.Parse(Console.ReadLine());
            holder = new List<int>();
            for(int b = 0; b <= a; b++){
                List<int> holderTemp = DavidMath.Collatz.CollatzList(b);
                if(holderTemp.Count > holder.Count){
                    holder = holderTemp;
                }
            }
            foreach (int x in holder)
                Console.WriteLine(x);

            Console.WriteLine("The longest Collatz number was:" + holder[0]);
            Console.WriteLine("With a length of: " + holder.Count);

            Console.ReadKey();
        }
    }
}