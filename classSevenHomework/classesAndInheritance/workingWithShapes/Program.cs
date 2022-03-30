using System;
using workingWithShapes.Modules;

namespace workingWithShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape square = new Shape("square", "red" , 2, 3);
            square.Move();

            Rectangle rectangle = new Rectangle(5, 10, "rectangle", "purple", 6, 7);
            rectangle.Move();
            rectangle.getPerimeter();
            rectangle.getArea();

            Circle cirlce = new Circle(5, "circle", "green", 8, 9);
            cirlce.Move();
            cirlce.getArea();
            cirlce.getPerimeter();

            

        }
    }
}
