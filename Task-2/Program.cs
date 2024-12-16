using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    using System;
    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double CalculateArea()
        {
            return radius * radius;
        }
    }

    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return width * height;
        }
    }

    class Triangle : Shape
    {
        private double length;
        private double height;

        public Triangle(double length, double height)
        {
            this.length = length;
            this.height = height;
        }
        public override double CalculateArea()
        {
            return length * height;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Shape circle = new Circle(4.1);
            Console.WriteLine($"Area of Circle: {circle.CalculateArea()}");

            Shape rectangle = new Rectangle(2.3,5.0);
            Console.WriteLine($"Area of Rectangle: {rectangle.CalculateArea()}");

            Shape triangle = new Triangle(3.2,4.5);
            Console.WriteLine($"Area of Triangle: {triangle.CalculateArea()}");

            Console.ReadLine();
        }

    }
}