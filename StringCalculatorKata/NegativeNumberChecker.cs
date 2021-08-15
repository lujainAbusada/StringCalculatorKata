using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorKata
{
    public class NegativeNumberChecker : INumberChecker
    {
        public virtual void CheckForNegativeNumbers(List<int> listOfNumbers)
        {
            if (ExtractNegativeNumbers(listOfNumbers).Count() > 0)
                throw new Exception($"Negatives are not allowed : {string.Join(",", ExtractNegativeNumbers(listOfNumbers).OrderByDescending(i => i))}");
        }

        public virtual List<int> ExtractNegativeNumbers(List<int> listOfNumbers)
        {
            return (from num in listOfNumbers
                    where num < 0
                    orderby num ascending
                    select num).ToList<int>();
        }
    }
}
