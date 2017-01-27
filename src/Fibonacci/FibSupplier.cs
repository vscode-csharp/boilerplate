using System;
using System.Collections.Generic;

namespace Fibonacci
{
    public class FibSupplier
    {
        public static IEnumerable<int> Stream()
        {
            int prev = 0, curr = 1;
            while(true) {
                int now = prev;
                prev = curr; 
                curr = now + prev;
                yield return now;
            }
        }
        
        public static Func<int> Func()
        {
            int prev = 0, curr = 1;
            return () => {
                int now = prev;
                prev = curr; 
                curr = now + prev;
                return now;
            };
        }
    }
}
