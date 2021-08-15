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
            string stringOfNumebersAndDelimiters = System.IO.File.ReadAllText(@"C:\Users\hp\source\repos\StringCalculatorKata\Numbers.txt");
            Console.WriteLine($"The text in file: \n {stringOfNumebersAndDelimiters}\n-----------------");
            NegativeNumberChecker negativeNumberChecker = new NegativeNumberChecker();
            BigNumberChecker bigNumberChecker = new BigNumberChecker();
            NumberExtractor numberExtractor = new NumberExtractor();
            DelimeterExtractor delimeterExtractor = new DelimeterExtractor();
            StringCalculator stringCalculator = new StringCalculator(negativeNumberChecker, bigNumberChecker, numberExtractor, delimeterExtractor);
            Console.WriteLine($"Sum={stringCalculator.FindSum(stringOfNumebersAndDelimiters)}");
        }
    }
}
