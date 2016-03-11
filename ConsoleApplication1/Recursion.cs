namespace DavidMath{
    public class Recursion{
        public static int Factorial(int a){
            if(a >= 1){
                if (a != 1)
                    a = a * Factorial(a - 1);
                return a;
            }
            return 0;
        }

        //returns nth number of the fibonacci sequence
        public static int Fibonacci(int a){
            if(a > 1){
                return Fibonacci(a - 1) + Fibonacci(a - 2);
            }
            if( a == 1)
                return 1;
            return 0;
        }
    }
}
