namespace Task3Bridge.Shapes
{
    public class Square : Shape
    {
        public override void Draw(IRenderer renderer)
        {
            renderer.Render("Square");
        }
    }
}
