using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Primes.Tests
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
            int[] expected1 = {2, 3, 5, 7, 11, 13, 17};
            Assert.Equal(expected1, PrimesSupplier.Stream().Take(expected1.Length));
            int[] expected = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31};
            var primes = ToIterator(PrimesSupplier.Func()).Take(expected.Length).ToArray();
            Assert.Equal(expected, primes);
        }

        private static IEnumerable<T> ToIterator<T>(Func<T> f)
        {
            while(true) yield return f();
        }

    }
}
