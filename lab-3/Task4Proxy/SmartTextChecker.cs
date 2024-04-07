namespace Task4Proxy
{
    public class SmartTextChecker : SmartTextReader
    {
        public new char[][] ReadFile(string path)
        {
            Console.WriteLine($"Відкриття файлу: {path}");
            var content = base.ReadFile(path);
            Console.WriteLine("Файл прочитано успішно.");

            int lineCount = content.Length;
            int charCount = 0;
            foreach (var line in content)
            {
                charCount += line.Length;
            }

            Console.WriteLine($"Кількість рядків: {lineCount}, Кількість символів: {charCount}");
            Console.WriteLine($"Закриття файлу: {path}");

            return content;
        }
    }
}
