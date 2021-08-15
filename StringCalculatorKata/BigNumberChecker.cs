using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorKata
{
    public class BigNumberChecker : INumberChecker
    {
        public List<int> IgnoreBigNumbers(List<int> listOfNumbers)
        {
            return (from num in listOfNumbers
                    where num <= Constants.largestPossibleNumber
                    select num).ToList<int>();
        }
    }
}
