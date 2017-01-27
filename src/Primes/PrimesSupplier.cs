using System;
using System.Linq;
using System.Collections.Generic;

namespace Primes
{
    public class PrimesSupplier
    {
        private readonly static List<int> primes = new List<int>{2, 3, 5, 7};

        private static bool IsPrime(int candidate) 
        {
            double max = Math.Sqrt(candidate);
                return !primes
                    .TakeWhile(nr => nr <= max)
                    .Any(divisor => candidate % divisor == 0);
        }

        public static IEnumerable<int> Stream() 
        {
            return primes.Concat(StreamFrom(primes.Last() + 1));
        }

        private static IEnumerable<int> StreamFrom(int init)
        {
            if(init % 2 == 0) init++;
            for(int candidate = init; ; candidate += 2) {
                if(IsPrime(candidate)) {
                    primes.Add(candidate);
                    yield return candidate;
                }
            }
        }
       
        public static Func<int> Func()
        {
            IEnumerator<int> iter = primes.GetEnumerator();
            Func<int> f = () => {
                if(iter.MoveNext()) return iter.Current; // First consume iter to the end
                f = ContinueFrom(primes.Last() + 1);     // Then reassign f with a new function
                return f();                              // Return the first result of the new function
            };
            return () => f(); // Returns a wrapper over f
        }

        private static Func<int> ContinueFrom(int candidate)
        {
            if(candidate % 2 == 0) candidate++;
            return () => {
                do{ candidate += 2; } while(!IsPrime(candidate));
                primes.Add(candidate);
                return candidate;
            };
        }
    }
}
