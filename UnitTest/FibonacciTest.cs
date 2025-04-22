using Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class FibonacciTest
    {
        private readonly Fibonacci _fibonacci;
        public FibonacciTest()
        {
            _fibonacci = new Fibonacci();
        }

        [Fact]
        public void BasicFibonacciTest()
        {

            Assert.NotNull(_fibonacci);

            Assert.Equal(0, _fibonacci.GetFibonacciNumber(0));
            Assert.Equal(1, _fibonacci.GetFibonacciNumber(1));
            Assert.Equal(1, _fibonacci.GetFibonacciNumber(2));
            Assert.Equal(89, _fibonacci.GetFibonacciNumber(11));

        }

        [Fact]
        public void Fibonacci_Bottom_Up_Test()
        {

            Assert.NotNull(_fibonacci);

            Assert.Equal(0, _fibonacci.GetFibonacciNumber_DP_Bottom_UP(0));
            Assert.Equal(1, _fibonacci.GetFibonacciNumber_DP_Bottom_UP(1));
            Assert.Equal(1, _fibonacci.GetFibonacciNumber_DP_Bottom_UP(2));
            Assert.Equal(89, _fibonacci.GetFibonacciNumber_DP_Bottom_UP(11));

        }

        [Fact]
        public void Fibonacci_Top_Down_Test()
        {

            Assert.NotNull(_fibonacci);

            Assert.Equal(0, _fibonacci.GetFibonacciNumber_DP_Top_Down(0));
            Assert.Equal(1, _fibonacci.GetFibonacciNumber_DP_Top_Down(1));
            Assert.Equal(1, _fibonacci.GetFibonacciNumber_DP_Top_Down(2));
            Assert.Equal(89, _fibonacci.GetFibonacciNumber_DP_Top_Down(11));

        }
    }
}
