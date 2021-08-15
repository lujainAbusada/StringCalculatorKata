using FluentAssertions;
using Moq;
using System.Collections.Generic;
using Xunit;
namespace StringCalculatorKata.Tests
{
    public class NumberExtractorShould
    {
        [Theory]
        [InlineData("//;\n1;2;3")]
        public void FindListOFNumbers_FromString(string stringOfNumbersAndDelimeters)
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
    }
}
