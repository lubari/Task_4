using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Square : Shape
    {
        private double side;
        public Square(double side)
        { 
            this.side = side;
        }
        public double Perimeter()
        {   double perimeter = this.side * 4;
            Console.WriteLine("Square perimeter: " + perimeter);
            return perimeter;
        }
        public double GetArea()
        {   
            double area = side * side;
            Console.WriteLine("Square perimeter is: " + area);
            return area;
        }
    }
    
}
