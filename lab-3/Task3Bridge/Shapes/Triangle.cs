namespace Task3Bridge.Shapes
{
    public class Triangle : Shape
    {
        public override void Draw(IRenderer renderer)
        {
            renderer.Render("Triangle");
        }
    }
}
