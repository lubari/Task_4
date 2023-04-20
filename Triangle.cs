using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Triangle : Shape
    {   private double baseTriangle;
        private double height;
        private double side1;
        private double side2;

        public Triangle(double baseTriangle, double height, double side1, double side2)
        {
            this.baseTriangle = baseTriangle;
            this.height = height;
            this.side1 = side1;
            this.side2 = side2;
        }

        public double Perimeter()
        {   
            double perimeter = baseTriangle + side1 + side2;
            Console.WriteLine("Triangle perimeter: "+perimeter);
            return perimeter;
        }

        public double GetArea()
        {   double area = (baseTriangle * height) / 2;
            Console.WriteLine("Triangle area is: "+area);
            return area;
        }
    }
}
