using System;
using System.IO;
using System.Linq;
using System.Text;

namespace StringCalculatorKata
{
    class Program
    {
        static void Main(string[] args)
        {   
            string _stringOfNumebersAndDelimiters =  System.IO.File.ReadAllText(@"C:\Users\hp\source\repos\StringCalculatorKata\Numbers.txt");
            Console.WriteLine($"The text in file: \n {_stringOfNumebersAndDelimiters}\n-----------------");
            NegativeNumberChecker _negativeNumberChecker = new NegativeNumberChecker();
            BigNumberChecker _bigNumberChecker = new BigNumberChecker();
            NumberExtractor _numberExtractor = new NumberExtractor();
            DelimeterExtractor _delimeterExtractor = new DelimeterExtractor();
            StringCalculator stringCalculator = new StringCalculator(_stringOfNumebersAndDelimiters, _negativeNumberChecker, _bigNumberChecker, _numberExtractor, _delimeterExtractor);
            Console.WriteLine($"Sum={stringCalculator.FindSum()}");
    }
}
}
