using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpClassandObjects2.more_classes
{
    internal class ClsDisplay
    {
        //creating object "laptop1"
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
