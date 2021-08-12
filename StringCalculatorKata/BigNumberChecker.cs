using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCalculatorKata
{
    public class BigNumberChecker:INumberChecker
    {
        public List<int> IgnoreBigNumbers(List<int> listOfNumbers)
        {
            return (from num in listOfNumbers
                    where num <= 1000
                    select num).ToList<int>();
        }
    }
}
