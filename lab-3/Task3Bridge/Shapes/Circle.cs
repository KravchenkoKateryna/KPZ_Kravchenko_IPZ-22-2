using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Bridge.Shapes
{
    public class Circle : Shape
    {
        public override void Draw(IRenderer renderer)
        {
            renderer.Render("Circle");
        }
    }
}
