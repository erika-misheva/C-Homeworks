using System;
using System.Collections.Generic;
using System.Text;

namespace workingWithShapes.Modules
{
    public class Shape
    {
        public string name;
        public string color;
        public int[] position = new int[2];
        public int x { get; set; }
        public int y { get; set; }

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                    Console.WriteLine("We are setting the property name");
                }
                else
                {
                    Console.WriteLine("You haven't entered an valid input");
                }
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                if (!string.IsNullOrEmpty(value) && (value == "black" || value == "white" ||
                    value == "pink" || value == "red" || value == "green"
                    || value == "purple" || value == "blue" || value == "yellow" || value == "orange"))
                {
                    color = value;
                    Console.WriteLine("We are setting the property color");
                }
                else
                {
                    Console.WriteLine("Please enter an valid color");
                }
            }
        }

        public int[] Position()
        {
           if(x !=0 && y != 0)
            {
                position[0] = x;
                position[1] = y;
            } else
            {
                Console.WriteLine("You haven't enterd an vaild data");
            }
            return position;
        }
        public int[] Move()
        {
            position[0] *=  5;
            position[1] *=  5;
            Console.WriteLine($"The position of the shape is {position[0]} and {position[1]}");
            return position;
        }

        public virtual void getArea()
        {
            Console.WriteLine("there is no special implementation for area");
        }
        public virtual void getPerimeter()
        {
            Console.WriteLine("there is no special implementation for perimeter");

        }

        public Shape(string name, string color, int X, int Y)
        {
            x = X;
            y = Y;
            position = Position();
            Name = name;
            Color = color;
        }



    }
}
