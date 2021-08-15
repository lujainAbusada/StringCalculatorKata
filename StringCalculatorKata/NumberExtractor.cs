using System;
using System.Collections.Generic;

namespace StringCalculatorKata
{
    public class NumberExtractor
    {
        List<int> _listOfNumbers = new List<int>();
        private string _stringOfNumbers;

        public List<int> FindListOfNumbers(string stringOfNumbersAndDelimeter, List<char> listOfDelimeters)
        {   
            if (stringOfNumbersAndDelimeter.Contains(Constants._newDelimiterSign))
                 _stringOfNumbers = stringOfNumbersAndDelimeter.Split(Constants._newLine, 2)[1];
            else
                _stringOfNumbers = stringOfNumbersAndDelimeter;
            
            foreach (string number in _stringOfNumbers.Split(listOfDelimeters.ToArray()))
            {
                _listOfNumbers.Add(Int16.Parse(number));
            }
            return _listOfNumbers;
        }
    }
}