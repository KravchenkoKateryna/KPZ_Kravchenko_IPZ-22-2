namespace Task4Proxy
{
    public class SmartTextReader
    {
        public char[][] ReadFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            char[][] content = new char[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                content[i] = lines[i].ToCharArray();
            }
            return content;
        }
    }
}
