using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Circle : Shape
    {
        private double radius;


        public Circle(double radius) 
        {
            this.radius = radius;
        }
        public double Perimeter()
        {   double perimeter = Math.PI * radius;
            Console.WriteLine("Circle perimeter is: ");
            return perimeter;
        }
        public double GetArea()
        {   double area = radius * radius * Math.PI;
            Console.WriteLine("Circle area is: "+ area);
            return area;
        }
    }
}
