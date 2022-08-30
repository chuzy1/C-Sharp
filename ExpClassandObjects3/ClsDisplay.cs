using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpClassandObjects3
{
    // Creating a class "ClsDisplay" and object "laptop1" as instance of Class "ClsLaptop"
    internal class ClsDisplay
    {
        static void Main()
        {
            ClsLaptop laptop1 = new();
            laptop1.brand = "Dell";
            laptop1.model = "Dell Inspiron";
            laptop1.RAM = 6;
            laptop1.size = 14;
            laptop1.processor = "i7";
            laptop1.HDD = 500;
            laptop1.DisplayFeatures();

        }
    }
}
