﻿using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(List<int> listOfNumbers)
        {
            return listOfNumbers.Aggregate((x, y) => x + y);
        }
    }
}