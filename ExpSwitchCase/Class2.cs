using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpSwitchCase
{
    internal class Class2
    {
        static void Main()
        {
            var b = " enter number";
            Console.WriteLine(b);
            b = Console.ReadLine();            
            switch (b)
            {

                case "1":
                    Console.WriteLine("One is your choice");
                    break;
                case "2":
                    Console.WriteLine("Two is your choice");
                    break;
                case "3":
                    Console.WriteLine("Three is your choice");
                    break;
                case "4":
                    Console.WriteLine("Four is your choice");
                    break;
                case "5":
                    Console.WriteLine("Five is your choice");
                    break;
                default:
                    Console.WriteLine("values one to five");
                    break;

            }
    }   }
}
