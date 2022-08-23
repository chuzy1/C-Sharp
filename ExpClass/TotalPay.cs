using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpClassandObjects1
{
    internal class TotalPay // calculate totalpays for objects Jones, Sandra, Andrew
    {
        static void Main()
        {
            ClsEmployee Jones = new();
            {
                Jones.salary = 18000;
                Jones.bonus = 2000;
                Console.WriteLine("Jones");
                Jones.CalculateTotalPay();
                Console.WriteLine("-----------------");
            }
            ClsEmployee Sandra = new();
            {
                Sandra.salary = 20000;
                Sandra.bonus = 2500;
                Console.WriteLine("Sandra");
                Sandra.CalculateTotalPay();
                Console.WriteLine("-----------------");
            }
            ClsEmployee Andrew = new();
            {
                Andrew.salary = 21000;
                Andrew.bonus = 3000;
                Console.WriteLine("Andrew");
                Andrew.CalculateTotalPay();
            }
        }
    }
}
