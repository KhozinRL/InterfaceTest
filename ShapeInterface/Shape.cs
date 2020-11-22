using System;
namespace ShapeInterface
{
    public abstract class Shape
    {
        public void Draw() {
            Console.WriteLine("Shape");
        }

        public void AnalyzeShape() {
            Console.WriteLine(ToString());
          
            Console.Write("Вызов Point: ");
            if (this is IPoint point)
                Console.WriteLine(point.Point);
            else
                Console.WriteLine("Интерфейс IPoint не реализован");

            Console.Write("Вызов метода Draw напрямую: ");
            Draw();

            Console.Write("Вызов метода Draw через интерфейс: ");
            if (this is IDrawable drawable)
                drawable.Draw();
            else
                Console.WriteLine("Интерфейс IDrawable не реализован");

            Console.WriteLine();
        }
    }
}
