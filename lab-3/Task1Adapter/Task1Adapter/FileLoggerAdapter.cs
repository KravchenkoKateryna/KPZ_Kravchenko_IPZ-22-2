namespace Task1Adapter
{
    internal class FileLoggerAdapter : Logger
    {
        private FileWriter _writer;

        public FileLoggerAdapter(string path)
        {
            _writer = new FileWriter(path);
        }

        public new void Log(string message)
        {
            _writer.WriteLine(message);
        }

        public new void Error(string message)
        {
            _writer.WriteLine("ERROR: " + message);
        }

        public new void Warn(string message)
        {
            _writer.WriteLine("WARNING: " + message);
        }
    }
}
