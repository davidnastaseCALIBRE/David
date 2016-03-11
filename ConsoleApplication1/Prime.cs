using System.Collections.Generic;
using System.Linq;

namespace DavidMath{
    public class Prime{
        public static bool IsPrime(int a){
            if (a < 2)
                return false;

            bool[] holder = new bool[a+1]; //default values are false, so we'll be inverting some.
            for (int b = 2; b < a; b++){
                if (!holder[b]) {
                    for(int c = b; c <= a; c += b){
                        if(c <= a &&  c != b){
                            holder[c] = true; 
                        }
                    }
                }
            }
            return !holder[a];
        }

        public static bool IsTwinPrime(int a){
            if (IsPrime(a))
                return IsPrime(a - 2) || IsPrime(a + 2);
            return false;
        }

        public static List<int> PrimeFactors(int a){
            List<int> holder = new List<int>();

            if (IsPrime(a))
                holder.Add(a);
            else{
                for(int x = 2; x < a; x++){
                    if(a % x == 0 && IsPrime(x)){
                        holder.Add(x);
                        holder.AddRange(PrimeFactors(a/ x));
                        break; //only try to find the first factor, avoid duplicates.
                    }
                }
            }
            return holder;
        }

        public static List<int> DistinctFactors(int a){
            List<int> holder = PrimeFactors(a).Distinct().ToList();
            return holder;
        }

        public static int NumDistinctFactors(int a){
            return DistinctFactors(a).Count;
        }
    }
}
