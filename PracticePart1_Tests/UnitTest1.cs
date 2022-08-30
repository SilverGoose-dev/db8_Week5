using PracticePart1;

namespace PracticePart1_Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(-1, -1)] // Group these together. Negative first.
        [InlineData(-2, -1)]
        [InlineData(0, 0)]
        [InlineData(1, 1)] // Group these together. Positives.
        [InlineData(2, 1)]
        public void TestGetSign(int value, int expected)
        {
            int actual = Coupon.GetSign(value);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5.0, 0)]
        [InlineData(9.99, 0)]
        [InlineData(10.00, 2)]
        [InlineData(19.99, 2)]
        [InlineData(20.00, 3)]
        [InlineData(20.01, 3)]
        [InlineData(100, 3)]
        public void TestCalcCoupon(decimal value, decimal expected)
        {
            decimal acutal = Coupon.CalculateCoupon(value);
            Assert.Equal(expected, acutal);
        }
    }


}