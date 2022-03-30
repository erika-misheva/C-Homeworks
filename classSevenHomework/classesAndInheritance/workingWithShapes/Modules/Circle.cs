using System;
namespace workingWithShapes.Modules
{
public class Circle : Shape
{
    public double Radius { get; set; }

        public override void getArea()
        {
            double area = Radius * 2 * Math.PI;
            Console.WriteLine($"The area of the rectangle is {area}");
        }
        public override void getPerimeter()
        {
            double perimeter = Radius * Radius * Math.PI;
            Console.WriteLine($"The perimeter of the rectangle is {perimeter}");

        }
        public Circle(double radius, string name, string color, int x, int y) : base(name, color, x, y)
        {
            Radius = radius;
        }
    }
}


