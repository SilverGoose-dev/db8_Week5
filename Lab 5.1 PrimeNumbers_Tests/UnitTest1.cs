using Lab_5._1_PrimeNumbers;

namespace Lab_5._1_PrimeNumbers_Tests
{
    public class UnitTest1
    {
        
        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(11, 31)]
        [InlineData(15, 47)]
        [InlineData(25, 97)]
        public void TestGetPrime(int value, int expected)
        {
            int actual = Prime.GetPrime(value);
            Assert.Equal(expected, actual);
        }
    }
}