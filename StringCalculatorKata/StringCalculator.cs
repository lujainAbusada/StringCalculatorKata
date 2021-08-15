using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        private readonly NegativeNumberChecker _negativeNumberChecker;
        private readonly BigNumberChecker _bigNumberChecker;
        private readonly NumberExtractor _numberExtractor;
        private readonly DelimeterExtractor _delimeterExtractor;

        public StringCalculator( NegativeNumberChecker negativeNumberChecker, BigNumberChecker bigNumberChecker, NumberExtractor numberExtractor, DelimeterExtractor delimeterExtractor)
        {
            _negativeNumberChecker = negativeNumberChecker;
            _bigNumberChecker = bigNumberChecker;
            _numberExtractor = numberExtractor;
            _delimeterExtractor = delimeterExtractor;
        }

        public StringCalculator()
        {
        }

        public int FindSum(string stringOfNumebersAndDelimiters)
        {
            List<int> listOfNumbers = _bigNumberChecker.IgnoreBigNumbers(_numberExtractor.FindListOfNumbers(stringOfNumebersAndDelimiters, _delimeterExtractor.FindDelimeter(stringOfNumebersAndDelimiters)));
            _negativeNumberChecker.CheckForNegativeNumbers(listOfNumbers);
            return Add(listOfNumbers);
        }

        public virtual int Add(List<int> listOfNumbers)
        {
            return listOfNumbers.Aggregate((x, y) => x + y);
        }
    }
}