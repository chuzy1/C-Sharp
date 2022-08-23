using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpClassandObjects2
{
    internal class ClsBox
    {
        public double Length;
        public double Width;
        public void CalculateArea()
        {
            double area = Length * Width;
            Console.WriteLine("Area = "+area+"cm");
        }
    }
}
