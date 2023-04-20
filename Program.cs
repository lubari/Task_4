using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape triangle = new Triangle(10,5, 4, 5);
            Shape circle = new Circle(4);
            Shape square = new Square(7);

            triangle.GetArea();
            triangle.Perimeter();
            circle.GetArea();
            circle.Perimeter();
            square.GetArea();
            square.Perimeter();
            Console.ReadKey();
        }
    }
}
