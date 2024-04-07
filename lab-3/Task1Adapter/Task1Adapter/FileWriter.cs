namespace Task1Adapter
{
    internal class FileWriter
    {
        private string _path;

        public FileWriter(string path)
        {
            _path = path;
        }

        public void Write(string message)
        {
            File.AppendAllText(_path, message);
        }

        public void WriteLine(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }
    }
}
