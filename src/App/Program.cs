using System;
using System.Collections.Generic;
using Fibonacci;
using Primes;

namespace App
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Print(10, FibSupplier.Stream().ToFunc());
            Print(20, FibSupplier.Func());

            Print(10, PrimesSupplier.Stream().ToFunc());
            Print(20, PrimesSupplier.Func());
        }

        private static Func<T> ToFunc<T>(this IEnumerable<T> from)
        {
            IEnumerator<T> iter = from.GetEnumerator();
            return () => { iter.MoveNext(); return iter.Current; };
        }

        private static void Print<T>(int count, Func<T> f) {
            for (int i = 0; i < count; i++)
            {
                Console.Write(f());
                Console.Write(' ');
            }
            Console.WriteLine();
        }

    }
}
