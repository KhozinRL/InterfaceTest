using System;

namespace ShapeInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[] {
                new Triangle(), new Hexagon(), new Circle(), new Sphere()
            };

            Console.WriteLine();
            foreach (Shape shape in shapes) {
                shape.AnalyzeShape();
            }


            Sphere sphere = new Sphere(); 
            Console.Write("Вызов 1 метода Draw для Sphere: ");
            sphere.Draw();
            Console.Write("Вызов 2 метода Draw для Sphere: ");
            ((IDrawable)sphere).Draw();
        }
    }
}
