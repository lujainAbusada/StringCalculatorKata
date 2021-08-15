using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace StringCalculatorKata.Tests
{
    public class BigNumberCheckerShould
    {
        [Fact]
        public void IgnoreBigNumbers()
        {
            //Arrange
            var listOfNumbers = new List<int> { 1, 1001, 3 };
            var bigNumberChecker = new BigNumberChecker();
            var expectedList = new List<int> { 1, 3 };
            //Act
            var actualList = bigNumberChecker.IgnoreBigNumbers(listOfNumbers);
            //Assert
            expectedList.Should().BeEquivalentTo(actualList);
        }
    }
}
