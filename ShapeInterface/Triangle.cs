using System;
namespace ShapeInterface
{
    public class Triangle : Shape, IPoint, IDrawable
    {
        public Triangle()
        {
        }

        public int Point {
            get {
                return 256;
            }
        }

        new public void Draw() {
            Console.WriteLine("Triangle");
        }
    }
}
