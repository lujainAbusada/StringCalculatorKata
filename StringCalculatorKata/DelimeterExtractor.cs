using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorKata
{
    public class DelimeterExtractor
    {
        public virtual List<char> FindDelimeter(string stringOfNumbersAndDelimeter)
        {
            return new List<char> {stringOfNumbersAndDelimeter.Split("\n")[0].Last(), ',', '\n' };
        }
    }
}
