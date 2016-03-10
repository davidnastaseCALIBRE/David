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
    }
}
