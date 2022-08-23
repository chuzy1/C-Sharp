using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpClassandObjects1 // progame to create class employee. This will be used to calculate total pay
{
    internal class ClsEmployee 
    {
        public double salary;
        public double bonus;
        public void CalculateTotalPay()
        {
            double totalPay = salary + bonus;
            Console.WriteLine("Total pay = "+totalPay);
        }
    }
}
