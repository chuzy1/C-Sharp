using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpClassandObjects2.more_classes
{
    internal class ClsLaptop
    {
        public string? brand;
        public string? model;
        public double size;
        public int HDD;
        public double RAM;
        public string? processor;

        //public string processor;

        public void DisplayFeatures()
        {
            //string? features = brand;
            Console.WriteLine(brand);
            Console.WriteLine(size);
            Console.WriteLine(HDD);
            Console.WriteLine(RAM);
            Console.WriteLine(processor);
        }
    }
}
