using System;
namespace ShapeInterface
{
    public class Sphere : Shape, IDrawable
    {
        public Sphere()
        {
        }

        void IDrawable.Draw() {
            Console.WriteLine("Sphere");
        }
    }
}
