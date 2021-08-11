using Xunit;

namespace StringCalculatorKata.Tests
{
    public class StringCalculatorShould
    {
        [Theory]
        [InlineData("0,1,2", 4)]
        [InlineData("0,2", 2)]
        [InlineData("1,2", 3)]
        [InlineData("5,9", 14)]
        public void AddUpToTwoNumbersInAString(string stringOfNumbers, int expectedSum)
        {
            //Arrange
            var stringCalculator = new StringCalculator();
            //Act
            var actualSum = stringCalculator.Add(stringOfNumbers);
            //Assert
            Assert.Equal(expectedSum, actualSum);
        }
    }
}