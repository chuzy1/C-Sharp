namespace ExpStringFormating
{
    internal class Class1
    {
        static void Main()
        {
            string g = "David Jones";
            Console.WriteLine(g);
            Console.WriteLine(g.ToUpper());
            Console.WriteLine(g.ToLower());
            Console.WriteLine(g.Length);
            Console.WriteLine(g.Substring(3));
            Console.WriteLine(g.Substring(4, 5)); // (index,character length)
            Console.WriteLine(g.IndexOf("J"));
            Console.WriteLine(g[6]);
            Console.WriteLine("-----------------");
            string[] num = { "One", "Two", "Three" };
            foreach (string s in num)
                Console.WriteLine(s);
            Console.WriteLine("-----------------");
            string u = "320";
            int Total1 = Convert.ToInt32(u);
            Console.WriteLine(Total1);
            Console.WriteLine("-----------------");
            string b = "83748.54";
            double Total2 = Convert.ToDouble(b);
            Console.WriteLine(Total2 *3);
            Console.WriteLine("-----------------");

        }

    }
}
