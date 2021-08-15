using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace StringCalculatorKata.Tests
{
    public class DelimeterExtractorShould
    {
        [Theory]
        [InlineData("//;\n0;1;2\n3")]
        public void FindDelimeterList(string stringOfNumbersAndDelimeters)
        {
            //Arrange
            var expectedDelimeterList = new List<char> { '\n', ',', ';' };
            var delimeterExtractor = new DelimeterExtractor();
            //Act
            var actualSum = delimeterExtractor.FindDelimeter(stringOfNumbersAndDelimeters);
            //Assert
            expectedDelimeterList.Should().BeEquivalentTo(actualSum);
        }
    }
}
