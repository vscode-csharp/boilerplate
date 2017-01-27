using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Primes.Test
{
    public class PrimesSupplierTests
    {
        [Fact]
        public void StreamTest() 
        {
            int[] expected = {2, 3, 5, 7, 11, 13, 17};
            Assert.Equal(expected, PrimesSupplier.Stream().Take(expected.Length));
        }

        [Fact]
        public void FuncTest() 
        {
            int[] expected = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31};
            var primes = ToIterator(PrimesSupplier.Func()).Take(expected.Length);
            Assert.Equal(expected, primes);
        }

        private static IEnumerable<T> ToIterator<T>(Func<T> f)
        {
            while(true) yield return f();
        }

    }
}
