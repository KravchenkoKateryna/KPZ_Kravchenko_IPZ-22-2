namespace Task3Bridge
{
    public class VectorRenderer : IRenderer
    {
        public void Render(string message)
        {
            Console.WriteLine($"Drawing {message} as vectors");
        }
    }
}
