using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class Dimensions
    {
        public double Length;
        public double Width;

        public Dimensions()
        {

        }
        public Dimensions(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public double Diagonal
        {
            get
            {
                return Sqrt(Length, Width);
            }
        }

        public double Sqrt(double Length, double Width)
        {
            return (Length * Length + Width * Width);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("unit-testing");
        }
    }
}
