using Task3Bridge.Shapes;

namespace Task3Bridge
{

    class Program
    {
        static void Main()
        {
            var vectorRenderer = new VectorRenderer();
            var rasterRenderer = new RasterRenderer();

            var circle = new Circle();
            var square = new Square();
            var triangle = new Triangle();

            // Векторний рендеринг
            circle.Draw(vectorRenderer);
            square.Draw(vectorRenderer);
            triangle.Draw(vectorRenderer);

            // Растровий рендеринг
            circle.Draw(rasterRenderer);
            square.Draw(rasterRenderer);
            triangle.Draw(rasterRenderer);
        }
    }
}