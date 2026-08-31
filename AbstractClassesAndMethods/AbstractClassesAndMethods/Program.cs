using System;

namespace AbstractShapesDemo
{
    // Abstract class: cannot be instantiated directly
    abstract class Shape
    {
        // Abstract method: must be implemented by any derived class
        public abstract double GetArea();
    }

    // Derived class: implements GetArea() for a circle
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    // Derived class: implements GetArea() for a rectangle
    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Abstract Classes and Methods ===");

            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            Console.WriteLine($"Circle area: {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle area: {rectangle.GetArea():F2}");
        }
    }
}
