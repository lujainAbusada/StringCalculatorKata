using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        private readonly string _stringOfNumebersAndDelimiters;
        private readonly NegativeNumberChecker _negativeNumberChecker;
        private readonly BigNumberChecker _bigNumberChecker;
        private readonly NumberExtractor _numberExtractor;
        private readonly DelimeterExtractor _delimeterExtractor;

        public StringCalculator(string stringOFNumebersAndDelimiters, NegativeNumberChecker negativeNumberChecker, BigNumberChecker bigNumberChecker, NumberExtractor numberExtractor, DelimeterExtractor delimeterExtractor)
        {
            _stringOfNumebersAndDelimiters = stringOFNumebersAndDelimiters;
            _negativeNumberChecker = negativeNumberChecker;
            _bigNumberChecker = bigNumberChecker;
            _numberExtractor = numberExtractor;
            _delimeterExtractor = delimeterExtractor;
        }

        public StringCalculator()
        {
        }

        public int FindSum()
        {
            List<int> listOfNumbers = _bigNumberChecker.IgnoreBigNumbers(_numberExtractor.FindListOfNumbers(_stringOfNumebersAndDelimiters, _delimeterExtractor.FindDelimeter(_stringOfNumebersAndDelimiters)));
            _negativeNumberChecker.CheckForNegativeNumbers(listOfNumbers);
            return Add(listOfNumbers);
        }

        public virtual int Add(List<int> listOfNumbers)
        {
            return listOfNumbers.Aggregate((x, y) => x + y);
        }
    }
}