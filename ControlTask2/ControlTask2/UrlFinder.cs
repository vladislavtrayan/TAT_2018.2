using System;
using System.Text.RegularExpressions;

namespace ControlTask2
{
    public class UrlFinder
    {
        public UrlFinder()
        {
        }
        public string FindUrl(string line)
        {
            //string[] inputs = { @"http://google.com", @"https://aa", @"\\a", @"\\\a" };

            Regex regEx = new Regex(@"^(http[s]{0,1}://|[\\]{2})(?:[\w][\w.-]?)+", RegexOptions.Compiled);
            var match = regEx.Match(line);
            return match.Value;
        }
    }
}
