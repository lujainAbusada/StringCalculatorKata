using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace StringCalculatorKata.Tests
{
    public class StringCalculatorShould
    {
        private readonly DelimeterExtractor _delimeterExtractor;
        private readonly NumberExtractor _numberExtractor;
        private readonly StringCalculator _stringCalculator;

        public StringCalculatorShould()
        {
            _delimeterExtractor = new DelimeterExtractor();
            _numberExtractor = new NumberExtractor();
            _stringCalculator = new StringCalculator();
        }

        [Theory]
        [InlineData("//;\n0;1;2\n3")]
        public void FindDelimeterList(string stringOfNumbersAndDelimeters)
        {
            //Arrange
            var expectedDelimeterList = new List<char> { '\n', ',', ';' };
            //Act
            var actualSum = _delimeterExtractor.FindDelimeter(stringOfNumbersAndDelimeters);
            //Assert
            expectedDelimeterList.Should().BeEquivalentTo(actualSum);
        }

        [Theory]
        [InlineData("//;\n1;2;3")]
        public void FindListOFNumbers(string stringOfNumbersAndDelimeters)
        {
            //Arrange
            var delimeterExtractor = new Mock<DelimeterExtractor>();
            delimeterExtractor.Setup(x => x.FindDelimeter(stringOfNumbersAndDelimeters)).Returns(new List<char> { ';', '\n', ',' });
            var numberExtractor = new NumberExtractor();
            var collection = new List<int> { 1, 2, 3 };
            //Act
            var actualSum = numberExtractor.FindListOfNumbers(stringOfNumbersAndDelimeters, delimeterExtractor.Object.FindDelimeter(stringOfNumbersAndDelimeters));
            //Assert
            collection.Should().BeEquivalentTo(actualSum);
        }

        [Theory]
        [InlineData("//;\n0;1;2;3", 6)]
        public void AddNumbersSeperatedByCommaOrNewLine(string stringOfNumbers, int expectedSum)
        {
            //Act
            var actualSum = _stringCalculator.Add(_numberExtractor.FindListOfNumbers(stringOfNumbers, _delimeterExtractor.FindDelimeter(stringOfNumbers)));
            //Assert
            Assert.Equal(expectedSum, actualSum);
        }

        [Theory]
        [InlineData("//;\n0;1;2;3", 6)]
        public void FindDelimiterAndAddNumbers(string stringOfNumbers, int expectedSum)
        {
            //Act
            var actualSum = _stringCalculator.Add(_numberExtractor.FindListOfNumbers(stringOfNumbers, _delimeterExtractor.FindDelimeter(stringOfNumbers)));
            //Assert
            Assert.Equal(expectedSum, actualSum);
        }

        [Fact]
        public void ThrowExceptionWhenANumberIsNegative()
        {
            //Arrange
            var listOFNumbers = new List<int> { -1, -2, 3 };
            var checkNumbers = new NegativeNumberChecker();
            //Assert
            checkNumbers.Invoking(x => x.CheckForNegativeNumbers(listOFNumbers))
            .Should().Throw<Exception>()
            .WithMessage("Negatives are not allowed : -1,-2");
        }
    }
}
