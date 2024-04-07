namespace Task1Adapter
{
    internal class Logger
    {
        public void Log(string message)
        {
            PrintMessage(message, ConsoleColor.Green);
        }

        public void Error(string message)
        {
            PrintMessage(message, ConsoleColor.Red);
        }

        public void Warn(string message)
        {
            PrintMessage(message, ConsoleColor.DarkYellow);
        }

        private void PrintMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
