using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpStringArray
{
    internal class Class1 // suming items in string array
    {
        static void Main() 
        {
            double v = .0;
            string[] nums = { "3.45", "3.87", "87.98", "56.7" };
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    double g = Convert.ToDouble(nums[i]);
                    Console.WriteLine(g);
                    v = v + g;
                }
            }
            Console.WriteLine("-----------------");
            Console.WriteLine("Total="+v);
                        
        }
    }
}
