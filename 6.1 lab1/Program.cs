using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1_lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle("Red", 5);
            Rectangle rect1 = new Rectangle("Blue", 7, 6);
            circle1.Display();
            rect1.Display();
        }
    }
    class Shape
    {

        public string Color;
        public Shape(string color)
        {
            Color = color;
        }
        public void Display()
        {
            Console.WriteLine($"This shape is {Color}");
        }

    }
    class Circle : Shape
    {
        private double Radius;
        public Circle(string color, double radius) : base(color)
        {
            Radius = radius;
        }
        public new void Display()
        {
            Console.WriteLine($"This circle is {Color} and the radius is {Radius}. ");
        }
    }
    class Rectangle : Shape
    {
        private int Length;
        private int Width;
        public Rectangle(string color, int length, int width) : base(color)
        {
            Length = length;
            Width = width;
        }
        public new void Display()
        {
            Console.WriteLine($"This rectangle is {Color} and has a length of {Length} and a width of {Width}.");
        }
    }
}
