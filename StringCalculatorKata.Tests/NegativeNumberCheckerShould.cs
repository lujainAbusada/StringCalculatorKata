using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace StringCalculatorKata.Tests
{
    public class NegativeNumberCheckerShould
    {

        [Fact]
        public void CheckForNegativeOfNumbers_FromAListThatContainsNegativeNumbers_ThrowException()
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
