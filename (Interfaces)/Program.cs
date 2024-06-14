using System;

namespace OOPDemoInterfaces
{
    // Define the IMovable interface
    public interface IMovable
    {
        void Move();
    }

    // Implementing the IMovable interface in Car class
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Implementing the IMovable interface in Bicycle class
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Car and Bicycle
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            // Call Move() method on each instance
            car.Move();      // Output: Car is moving
            bicycle.Move();  // Output: Bicycle is moving

            // Keep the console window open
            Console.ReadLine();
        }
    }
}