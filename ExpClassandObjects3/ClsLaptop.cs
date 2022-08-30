using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpClassandObjects3
{
    // creating a class called "ClsLaptop" with its properties and method
    internal class ClsLaptop
    {
        public string? brand;
        public string? model;
        public double size;
        public int HDD;
        public int RAM;
        public string? processor;

        //public string processor;

        public void DisplayFeatures()
        {
            string? features = brand;
            Console.WriteLine(brand+" Laptop");
            Console.WriteLine("Screen size "+size+"inch");
            Console.WriteLine("HDD "+HDD+"gb");
            Console.WriteLine("RAM "+RAM+"gb");
            Console.WriteLine("Processor "+processor);
        }
    }
}
