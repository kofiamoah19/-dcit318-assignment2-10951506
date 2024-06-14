using System;

namespace AbstractClassDemo
{
    // Abstract class
    public abstract class Shape
    {
        // Abstract method
        public abstract double GetArea();
    }

    // Derived class Circle
    public class Circle : Shape
    {
        private double radius;

        // Constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Implement GetArea method
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    // Derived class Rectangle
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        // Constructor
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Implement GetArea method
        public override double GetArea()
        {
            return width * height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Circle and Rectangle
            Circle circle = new Circle(3.0);
            Rectangle rectangle = new Rectangle(8.0, 2.0);

            // Display the areas
            Console.WriteLine("Area of the circle: " + circle.GetArea());       // Output: Area of the circle: 78.53981633974483
            Console.WriteLine("Area of the rectangle: " + rectangle.GetArea()); // Output: Area of the rectangle: 24

            // Keep the console window open
            Console.ReadLine();
        }
    }
}