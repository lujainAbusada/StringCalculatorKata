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
            int sum = 0;
            var listOfNumbers = stringOfNumbers.Split(',','\n');
            foreach(string number in listOfNumbers)
            {
                sum+= Int32.Parse(number);
            }
            return sum;
        }
    }
}