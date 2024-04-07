using System.Text.RegularExpressions;

namespace Task4Proxy
{
    public class SmartTextReaderLocker : SmartTextReader
    {
        private Regex _fileRestrictionPattern;

        public SmartTextReaderLocker(string pattern)
        {
            _fileRestrictionPattern = new Regex(pattern);
        }

        public new char[][]? ReadFile(string path)
        {
            if (_fileRestrictionPattern.IsMatch(path))
            {
                Console.WriteLine("Access denied!");
                return null;
            }
            return base.ReadFile(path);
        }
    }
}
