using System;
namespace ShapeInterface
{
    public class Hexagon : Shape, IPoint
    {
        public Hexagon()
        {
        }

        public int Point {
            get {
                return 512;
            }
        }
    }
}
