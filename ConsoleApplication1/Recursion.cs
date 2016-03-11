using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***
*Yes yes these aren't tested. I just like writing these out when I'm bored. 
*Love recursion.
*/
namespace DavidMath{
    public class Recursion{
        public static int factorial(int a){
            if(a != 1){
                a = a*factorial(a - 1);
            }
            return a;
        }

        //returns nth number of the fibonacci sequence
        public static int fibonacci(int a){
            if(a > 1){
                return fibonacci(a - 1) + fibonacci(a - 2);
            }
            if( a == 1)
                return 1;
            return 0;
        }
    }
}
