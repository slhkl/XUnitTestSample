namespace XUnitTestSample
{
    public class CalculatorTests
    {
        #region Integer

        [Theory]
        [InlineData(0, 1, 1)]
        [InlineData(1, 0, 1)]
        [InlineData(0, -1, -1)]
        [InlineData(-1, 0, -1)]
        [InlineData(-1, 1, 0)]
        [InlineData(1, -1, 0)]
        public void SumInt(int number1, int number2, int expected)
        {
            Assert.Equal(expected, Calculator<int>.Sum(number1, number2));
        }

        [Theory]
        [InlineData(0, 1, -1)]
        [InlineData(1, 0, 1)]
        [InlineData(0, -1, 1)]
        [InlineData(-1, 0, -1)]
        [InlineData(-1, 1, -2)]
        [InlineData(1, -1, 2)]
        public void SubtractInt(int number1, int number2, int expected)
        {
            Assert.Equal(expected, Calculator<int>.Subtract(number1, number2));
        }

        [Theory]
        [InlineData(0, 1, 0)]
        [InlineData(1, 0, 0)]
        [InlineData(0, -1, 0)]
        [InlineData(-1, 0, 0)]
        [InlineData(-1, 1, -1)]
        [InlineData(1, -1, -1)]
        public void MultipyInt(int number1, int number2, int expected)
        {
            Assert.Equal(expected, Calculator<int>.Multiply(number1, number2));
        }

        [Theory]
        [InlineData(0, 1, 0)]
        [InlineData(1, 0, int.MaxValue)]
        [InlineData(0, -1, 0)]
        [InlineData(-1, 0, int.MinValue)]
        [InlineData(-1, 1, -1)]
        [InlineData(1, -1, -1)]
        public void DivideInt(int number1, int number2, int expected)
        {
            Assert.Equal(expected, Calculator<int>.Divide(number1, number2));
        }

        [Fact]
        public void DivideZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => Calculator<int>.Divide(1, 0));
        }

        #endregion

        #region Double

        [Theory]
        [InlineData(0.0, 1.0, 1.0)]
        [InlineData(1.0, 0.0, 1.0)]
        [InlineData(0.0, -1.0, -1.0)]
        [InlineData(-1.0, 0.0, -1.0)]
        [InlineData(-1.0, 1.0, 0.0)]
        [InlineData(1.0, -1.0, 0.0)]
        public void SumDouble(double number1, double number2, double expected)
        {
            Assert.Equal(expected, Calculator<double>.Sum(number1, number2));
        }

        [Theory]
        [InlineData(0.0, 1.0, -1.0)]
        [InlineData(1.0, 0.0, 1.0)]
        [InlineData(0.0, -1.0, 1.0)]
        [InlineData(-1.0, 0.0, -1.0)]
        [InlineData(-1.0, 1.0, -2.0)]
        [InlineData(1.0, -1.0, 2.0)]
        public void SubtractDouble(double number1, double number2, double expected)
        {
            Assert.Equal(expected, Calculator<double>.Subtract(number1, number2));
        }

        [Theory]
        [InlineData(0.0, 1.0, 0.0)]
        [InlineData(1.0, 0.0, 0.0)]
        [InlineData(0.0, -1.0, 0.0)]
        [InlineData(-1.0, 0.0, 0.0)]
        [InlineData(-1.0, 1.0, -1.0)]
        [InlineData(1.0, -1.0, -1.0)]
        public void MultiplyDouble(double number1, double number2, double expected)
        {
            Assert.Equal(expected, Calculator<double>.Multiply(number1, number2));
        }

        [Theory]
        [InlineData(0.0, 1.0, 0.0)]
        [InlineData(1.0, 0.0, double.PositiveInfinity)]
        [InlineData(0.0, -1.0, 0.0)]
        [InlineData(-1.0, 0.0, double.NegativeInfinity)]
        [InlineData(-1.0, 1.0, -1.0)]
        [InlineData(1.0, -1.0, -1.0)]
        public void DivideDouble(double number1, double number2, double expected)
        {
            Assert.Equal(expected, Calculator<double>.Divide(number1, number2));
        }

        [Fact]
        public void IsInfinity()
        {
            Assert.True(double.IsPositiveInfinity(Calculator<double>.Divide(1.0, 0.0)));
        }

        #endregion

        #region String

        [Theory]
        [InlineData("Welcome to turkiye", "turk")]
        [InlineData("Welcome to turkiye", "Turk")]
        [InlineData("Welcome to turkiye", "here")]
        public void Contains(string text, string keyword)
        {
            Assert.Contains(keyword, text);
        }

        [Theory]
        [InlineData("Welcome to turkiye", "turk")]
        [InlineData("Welcome to turkiye", "Turk")]
        [InlineData("Welcome to turkiye", "here")]
        public void ContainsWithoutKeySensitive(string text, string keyword)
        {
            Assert.Contains(keyword, text, StringComparison.InvariantCultureIgnoreCase);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("Test")]
        public void IsNull(string parameter)
        {
            Assert.Null(parameter);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("Test")]
        public void IsNotNull(string parameter)
        {
            Assert.NotNull(parameter);
        }

        #endregion
    }
}