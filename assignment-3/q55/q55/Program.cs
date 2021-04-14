using System;

namespace q55
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of A :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of B :");
            int b = Convert.ToInt32(Console.ReadLine());
                a = ++a;
                a*= b++;
            Console.WriteLine("in Post increment of b result is : " + a);
            a = ++a;
            a *= ++b;
            Console.WriteLine("in pre increment of b result is : " + a);

        }
    }
}
