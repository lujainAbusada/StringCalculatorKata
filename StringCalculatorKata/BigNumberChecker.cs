using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorKata
{
    public class BigNumberChecker
    {
        public virtual List<int> IgnoreBigNumbers(List<int> listOfNumbers)
        {
            return (from num in listOfNumbers
                    where num <= Constants.LARGEST_POSSIBLE_NUMBER
                    select num).ToList<int>();
        }
    }
}
