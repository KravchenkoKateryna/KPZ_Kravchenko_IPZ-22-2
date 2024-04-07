namespace Task3Bridge
{
    public class RasterRenderer : IRenderer
    {
        public void Render(string message)
        {
            Console.WriteLine($"Drawing {message} as pixels");
        }
    }
}
