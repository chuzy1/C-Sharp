using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Salary
{
    internal class Class1
    {
        
        static void Main()
        {
           /*
            tax calculation on salary.
           */
            double tax;
            Console.WriteLine(" Please enter salary ");                        
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-----------------");
            if (salary <= 8350)
            {
                tax = salary * .10;
                Console.WriteLine("Tax = "+tax);
            }
            else if (salary > 8350 && salary <= 33950)
            {
                tax = (8350*.10)+((salary-8350) * .15);
                Console.WriteLine("Tax = "+tax);
            }
            else if (salary > 33950)
            {
                tax = (8350*.10)+((33950-8350)*.15)+(salary-33950) * .25;
                Console.WriteLine("Tax = "+tax);
            }
            
        }
    }
}
