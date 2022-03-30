using System;
using System.Collections.Generic;
using System.Text;

namespace workingWithShapes.Modules
{
    public class Rectangle : Shape
    {
        public int sideA { get; set; }
        public int sideB { get; set; }

        public override void getArea()
        {
            int area = sideA * sideB;   
            Console.WriteLine($"The area of the rectangle is {area}");
        }
        public override void getPerimeter()
        {
            int perimeter = 2 * (sideA + sideB);
            Console.WriteLine($"The perimeter of the rectangle is {perimeter}");

        }
        public Rectangle(int SideA, int SideB, string name, string color, int x, int y) : base(name, color, x, y)
        {
            sideA = SideA;
            sideB = SideB;
        }

    }
}
