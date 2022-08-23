using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpLowerCase
{
    internal class Class1 // printing substrings
    {
        static void Main()
        {
            string a = "Hello World";
            Console.WriteLine(a.Substring(6).ToLower());
            Console.WriteLine(a.Substring(6).ToUpper());
        }
            
    }
}
