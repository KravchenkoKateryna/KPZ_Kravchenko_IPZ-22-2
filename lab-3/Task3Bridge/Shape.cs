namespace Task3Bridge
{
    public abstract class Shape
    {
        public string Name { get; set; }
        public abstract void Draw(IRenderer renderer);
    }
}
