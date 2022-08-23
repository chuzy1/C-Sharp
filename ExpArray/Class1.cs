using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpArray
{
    internal class Class1
    {
        static void Main()
        {
            int[] a = { 1, 2, 3, 4, 5 }; // Creating an array with items
            Console.WriteLine(a.Length);
            Console.WriteLine(a[0]);
            a[2] = 6;
            Console.WriteLine(a[2]);
            Console.WriteLine(a[3]);
            Console.WriteLine("-----------------");
            for (int i =0; i < a.Length; i++) // Looping through a with 'for' keyword
            {
                Console.WriteLine("a["+i+"] = " + a[i]);
            }
            Console.WriteLine("-----------------");
            foreach (int itm in a) // Looping through a with 'foreach' keyword
            {
                int itmy = itm * 2;
                Console.WriteLine(itmy);               
            }
            Console.WriteLine("-----------------");
            int[] b = new int[5]; // creating array by assigning length of array
            for (int i = 0; i < b.Length;i++)
            {
                Console.WriteLine(b[i]);               
            }
            Console.WriteLine("-----------------");
            foreach (int m in b)
            {
                Console.WriteLine(m+100);
            }
            Console.WriteLine("-----------------");
            string[] c = new string[5];
            foreach(string s in c)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-----------------");
            string[] h = { "One", "Two", "Three", "Four", "Five" };
            {
                for (int i = 0; i < h.Length; i++)
                Console.WriteLine(h[i]);               
            }


        }
    }
}
