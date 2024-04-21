namespace Strategy
{
    internal class NetworkImageLoader : ILoad
    {
        public void LoadImage(string href)
        {
            // Логіка завантаження зображення з мережі
            Console.WriteLine($"Завантаження зображення з мережі: {href}");
            // Реалізуйте фактичний код тут
        }
    }
}
