using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1 // Operators
{
    class Class1
    {
        static void Main()
        {
            Console.WriteLine("Helo,Helo,Helo");
            int X = 8;
            int Y = 4;
            int Result = X + Y; // Addition
            Console.WriteLine("X + Y = " + Result);
            Result = X - Y; //Subtraction
            Console.WriteLine("X - Y = "+Result);
            Result = X % Y; //Mode operator
            Console.WriteLine("X % Y = " + Result);
            Result = X / Y; //Division
            Console.WriteLine("X / Y = "+Result);
            Result =X * Y; // Multiplication
            Console.WriteLine("X * Y = "+Result);
            X++; // increament
            Console.WriteLine("X++ = "+X+ " Value of X increased");
            X--; // Dicreament
            Console.WriteLine("X-- = " + X + " Value of X dicreased");
            X += 1; // Addition assignment
            Console.WriteLine("X+=1, means X =X+1 = " +X);
            X -= 1;
            Console.WriteLine("X-=1, means X =X-1 = "+X);
            X *= 1; // Multiplication assignment
            Console.WriteLine("X*=1, means X =X*1 = " + X);
            X /= 1; // Division assignment
            Console.WriteLine("X/=1, means X =X/1 = " + X);
            X %= 10; // Modulus assignment
            Console.WriteLine("X%=1, means X =X%1 = " + X);
            Console.WriteLine("{0} + {1} = {2}",X,Y,(X+Y)); //String formating using place holder

        }
    }
}
