using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp2
{
    internal class Class1// If statement
    {
        static void Main()
        {
            
            int X = 340;
            int Y = 340;
            if (X > Y)
            {
                Console.WriteLine("X is greater than Y"+"\nX is {0} and Y is {1}",X,Y);
            }
            if (X==Y)
            {
                Console.WriteLine("X is equal to Y" + "\nX is {0} and Y is {1}", X, Y);
            }
            else
            {
                Console.WriteLine("X is less than Y" + "\nX is {0} and Y is {1}", X, Y);
            }
        }
    }
}
