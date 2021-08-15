using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace StringCalculatorKata.Tests
{
    public class StringCalculatorShould
    {
        

        [Fact]
        public void AddNumbers()
        {
            //Arrange
            var stringCalculator = new StringCalculator();
            List<int> listOfNumbers = new List<int> { 1, 2, 3, 4 };
            int expectedSum = 10;
            //Act
            var actualSum = stringCalculator.Add(listOfNumbers);
            //Assert
            Assert.Equal(expectedSum, actualSum);
        }

        [Theory]
        [InlineData("//;\n0;1;2\n3;2000",6)]
        public void FindSumFromString(string stringOfNumbersAndDelimiters , int excpectedSum)
        {
            //Arrange
            var bigNumberChecker = new Mock<BigNumberChecker>();
            bigNumberChecker.Setup(x => x.IgnoreBigNumbers(new List<int> { 1, 2, 3, 2000 })).Returns(new List<int> { 1,2,3});
            var delimeterExtractor = new Mock<DelimeterExtractor>();
            delimeterExtractor.Setup(x => x.FindDelimeter(stringOfNumbersAndDelimiters)).Returns(new List<char> { ';', '\n', ',' });
            var numberExtractor = new Mock<NumberExtractor>();
            numberExtractor.Setup(x => x.FindListOfNumbers(stringOfNumbersAndDelimiters, new List<char> { ',', '\n', ';' })).Returns(new List<int> { 1, 2, 3,2000 });
            var negativeNumberChecker = new Mock<NegativeNumberChecker>();
            negativeNumberChecker.Setup(x => x.CheckForNegativeNumbers(new List<int> { 1, 2, 3, 2000 })).Throws<Exception>();
            //Act
            StringCalculator _stringCalculator = new StringCalculator(negativeNumberChecker.Object,bigNumberChecker.Object, numberExtractor.Object, delimeterExtractor.Object);
            int actualSum= _stringCalculator.FindSum(stringOfNumbersAndDelimiters);
            //Assert
            Assert.Equal(excpectedSum, actualSum);

        }

    }
}
