using System;
using System.Collections.Generic;

namespace StringCalculatorKata
{
    public class NumberExtractor
    {
        public List<int> FindListOfNumbers(string stringOfNumbersAndDelimeter, List<char> listOfDelimeters)
        {
            var stringOfNumbers = stringOfNumbersAndDelimeter.Split("\n", 2)[1];
            List<int> listOfNumbers = new List<int>();
            foreach (string number in stringOfNumbers.Split(listOfDelimeters.ToArray()))
            {
                listOfNumbers.Add(Int16.Parse(number));
            }
            return listOfNumbers;
        }
    }
}