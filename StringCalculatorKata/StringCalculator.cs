using System;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public StringCalculator()
        {
        }

        public int Add(string stringOfNumbers)
        {
            switch (stringOfNumbers.Length)
            {
                case 1: return Int32.Parse(stringOfNumbers);
                case 3: return (int)(Char.GetNumericValue(stringOfNumbers[0]) + Char.GetNumericValue(stringOfNumbers[2]));
                default: return 0;
            }
        }
    }
}