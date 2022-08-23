using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpAndOr
{
    internal class Class1
    {
        static void Main()
        {
            int X = -10;
            int Y = 10;
             if (X >= 0 && Y >= 0) // '&& (short and)' checks the first true condition
            {
                Console.WriteLine("'X' is Greater than zero, 'Y' is greater than zero");
            }
            if (X >= 0 || Y >= 0) // '||(short or)' checks the first true condition
            {
                Console.WriteLine("'X' is less than zero, 'Y' greater");
            }
            if (X <= 0 && Y <= 0)
            {
                Console.WriteLine("'X' is greater than zero");
            }
            if (X <= 0 || Y <= 0) // '||(short or)' checks the first true condition
            {
                Console.WriteLine("'X' is less than zero");
            }
            if (X <= 0 | Y >= 0) // '|(long or)' checks both condition
            {
                Console.WriteLine("'X' is less than zero, 0r 'Y' is greater than zero");
            }
            if (Y >= 0 & X <= 0) // '&(long and)' checks both condition
            {
                Console.WriteLine("'X' is less than zero, and 'Y' is greater than zero");
            }




        }
    }
}
