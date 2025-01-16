using Problems;

namespace UnitTest
{
    public class LargestPalindromeTest
    {
        [Fact]
        public void Test()
        {
            LargestPalindrome LP = new LargestPalindrome();

            string result = LP.Solution("abba");

            Assert.Equal("abba", result);

            result = LP.Solution("ba");
            Assert.Equal("b", result);

            result = LP.Solution("a");
            Assert.Equal("a", result);

            result = LP.Solution("noonmadamracecar");
            Assert.Equal("racecar", result);

            result = LP.Solution(string.Empty);
            Assert.Equal(string.Empty, result);
        }
    }
}