using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorKata
{
    public class DelimeterExtractor
    {
        private readonly List<char> _listOfDelimiters = new List<char> { ',', '\n' };

        public virtual List<char> FindDelimeter(string stringOfNumbersAndDelimeter)
        {
            if (stringOfNumbersAndDelimeter.Contains(Constants.NEW_DELIMITER_SIGN))
                _listOfDelimiters.Add(stringOfNumbersAndDelimeter.Split(Constants.NEW_LINE)[0].ElementAt(2));

            return _listOfDelimiters;
        }
    }
}
