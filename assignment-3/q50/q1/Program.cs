using System;

namespace q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 2;
            int z = 3;
            int j = 9;
            int k = 6;
            int area = x * x;
            int a = (x*x) + (3 * x) - 4;
            int b = (x+y)*z;
            var c = (x + (3 * y)) / ((2 * x) - y);
            var d = 1 / ((x * x) + x + 3);
            var e = (x + y) / 7;
            int f = 2 * b * c * 3;
            var g = (3 * y) / (5 - z);
            var h = area * (Math.Sqrt(area));
            var i = ((x+32)/(y-32))-(x-(2-y));
            var res = ((3*i*j*k)+(k^9))/((7*i*k)-(5* Math.Sqrt(j)+k));
            Console.WriteLine("Problem A is: "+a);
            Console.WriteLine("Problem B is: " + b);
            Console.WriteLine("Problem C is: " + c);
            Console.WriteLine("Problem E is: " + e);
            Console.WriteLine("Problem F is: " + f);
            Console.WriteLine("Problem G is: " + g);
            Console.WriteLine("Problem H is: " + h);
            Console.WriteLine("Problem I is: " + i);
            Console.WriteLine("Problem j is: " + res);
        }
    }
}
