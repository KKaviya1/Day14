using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Creating instances of Circle, Rectangle, and Triangle
            //Circle circle = new Circle(6);
            //Rectangle rectangle = new Rectangle(2, 4);
            //Triangle triangle = new Triangle(2, 3, 4);

            //// Printing information and calculating the area and perimeter of each shape
            //circle.PrintInfo();
            //rectangle.PrintInfo();
            //triangle.PrintInfo();



            double radius, width, height, sideA, sideB, sideC;

            // Get input for the Circle
            Console.Write("Enter the radius of the Circle: ");
            if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
            {
                Console.WriteLine("Invalid input for the radius of the Circle.");
                return;
            }

            Circle circle = new Circle(radius);

            // Get input for the Rectangle
            Console.WriteLine(" ");
            Console.Write("Enter the width of the Rectangle: ");
            if (!double.TryParse(Console.ReadLine(), out width) || width <= 0)
            {
                Console.WriteLine("Invalid input for the width of the Rectangle.");
                return;
            }

            Console.Write("Enter the height of the Rectangle: ");
            if (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
            {
                Console.WriteLine("Invalid input for the height of the Rectangle.");
                return;
            }

            Rectangle rectangle = new Rectangle(width, height);

            // Get input for the Triangle
            Console.WriteLine(" ");
            Console.Write("Enter the length of side A of the Triangle: ");
            if (!double.TryParse(Console.ReadLine(), out sideA) || sideA <= 0)
            {
                Console.WriteLine("Invalid input for the length of side A of the Triangle.");
                return;
            }

            Console.Write("Enter the length of side B of the Triangle: ");
            if (!double.TryParse(Console.ReadLine(), out sideB) || sideB <= 0)
            {
                Console.WriteLine("Invalid input for the length of side B of the Triangle.");
                return;
            }

            Console.Write("Enter the length of side C of the Triangle: ");
            if (!double.TryParse(Console.ReadLine(), out sideC) || sideC <= 0)
            {
                Console.WriteLine("Invalid input for the length of side C of the Triangle.");
                return;
            }
            Console.WriteLine(" ");

            Triangle triangle = new Triangle(sideA, sideB, sideC);

            circle.PrintInfo();
            rectangle.PrintInfo();
            triangle.PrintInfo();

            Console.ReadKey();
        }
    }

}
      