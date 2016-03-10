using System.Collections.Generic;

namespace DavidMath{
    public class Collatz{
        public static List<int> collatzList(int a){
            List<int> holder = new List<int>();
            if(a > 0){
                holder.Add(a);
                if(a != 1){
                    if(a % 2 == 0)
                        holder.AddRange(collatzList(a/2));
                    else
                        holder.AddRange(collatzList((a * 3) + 1));
                }
            }
            return holder;
        }

        public static int collatzLength(int a){
            return collatzList(a).Count;
        }
    }
}
