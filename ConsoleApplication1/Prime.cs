using System.Collections.Generic;
using System.Linq;

namespace DavidMath
{
    public class Prime
    {
        public static bool isPrime(int a)
        {
            if (a < 2)
            {
                return false;
            }
            bool[] holder = new bool[a+1]; //default values are false, so we'll be inverting some.
            for (int b = 2; b < a; b++)
            {
                if (!holder[b]) 
                {
                    for(int c = b; c <= a; c += b)
                    {
                        if(c <= a &&  c != b)
                        {
                            holder[c] = true; 
                        }
                    }
                }
            }
            return !holder[a];
        }

        public static bool isTwinPrime(int a)
        {
            if (isPrime(a))
            {
                return isPrime(a - 2) || isPrime(a + 2);
            }
            return false;
        }

        public static List<int> primeFactors(int a)
        {
            List<int> holder = new List<int>();

            if (isPrime(a))
            {
                holder.Add(a);
            }
            else
            {
                for(int x = 2; x < a; x++)
                {
                    if(a % x == 0 && isPrime(x))
                    {
                        holder.Add(x);
                        holder.AddRange(primeFactors(a/ x));
                        break; //only try to find the first factor, avoid duplicates.
                    }
                }
            }
            return holder;
        }

        public static List<int> distinctFactors(int a)
        {
            List<int> holder = primeFactors(a).Distinct().ToList();
            return holder;
        }

        public static int numDistinctFactors(int a)
        {
            return distinctFactors(a).Count;
        }
    }
}
