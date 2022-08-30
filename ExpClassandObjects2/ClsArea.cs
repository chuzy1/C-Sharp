using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpClassandObjects2
{
    internal class ClsArea
    {
       static void main()
        {
            ClsBox ups = new();
            ups.Length = 20;
            ups.Width = 10;
            Console.WriteLine("UPS box:");
            ups.CalculateArea();
            Console.WriteLine("-----------------");
            ClsBox DHL = new();
            DHL.Length = 40;
            DHL.Width = 10; 
            Console.WriteLine("DHL box:");
            DHL.CalculateArea();
            Console.WriteLine("-----------------");
            ClsBox Airexpress=new();
            Airexpress.Length = 25;
            Airexpress.Width = 10;
            Console.WriteLine("Airexpress box:");
            Airexpress.CalculateArea();

        }
    }
}
