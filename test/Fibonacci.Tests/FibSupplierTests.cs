using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Fibonacci.Tests
{
    public class FibSupplierTests
    {
        [Fact]
        public void StreamTest() 
        {
            int[] expected = {0, 1, 1, 2, 3, 5, 8, 13, 21, 34};
            Assert.Equal(expected, FibSupplier.Stream().Take(expected.Length));
        }

        [Fact]
        public void FuncTest() 
        {
            int[] expected = {0, 1, 1, 2, 3, 5, 8, 13, 21, 34};
            var fibs = ToIterator(FibSupplier.Func()).Take(expected.Length);
            Assert.Equal(expected, fibs);
        }

        private static IEnumerable<T> ToIterator<T>(Func<T> f)
        {
            while(true) yield return f();
        }
    }
}
