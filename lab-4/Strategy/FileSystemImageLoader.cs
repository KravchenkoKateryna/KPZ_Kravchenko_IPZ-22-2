namespace Strategy
{
    internal class FileSystemImageLoader : ILoad
    {
        public void LoadImage(string href)
        {
            if (File.Exists(href))
            {
                Console.WriteLine($"Завантаження зображення з файлової системи: {href}");
            }
            else
            {
                Console.WriteLine("Зображення не знайдене.");
            }

        }
    }
}
