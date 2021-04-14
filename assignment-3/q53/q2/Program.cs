using System;

namespace q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of X :");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of Y :");
            int y = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Which one,, Do you want to Execute (a,b,c,d,e,f,g,h)");
            string problemNumber = Console.ReadLine();
            Console.WriteLine("Problem # " + problemNumber + " is going to Execute" + "  The value of X is: " + x + "   The value of Y is : " + y);
            switch (problemNumber)
            {
                case "a":
                    x = (y++) + (x++);
                    y = (++y) + (++x);
                    Console.WriteLine("  The value of X is: " + x + "   The value of Y is : " + y);
                    break;
                case "b":
                    x = x++;
                    y = ++y;
                    Console.WriteLine("  The value of X is: " + x + "   The value of Y is : " + y);
                    break;
                case "c":
                    x = x++;
                    Console.WriteLine("  The value of X is: " + x);
                    break;
                case "d":
                    Console.WriteLine("  The value of X is: " + x++);
                    break;
                case "e":
                    x = y--;
                    Console.WriteLine("  The value of X is: " + x );
                    break;
                case "f":
                    Console.WriteLine("Enter value of j :");
                    int j = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter value of k :");
                    int k = Convert.ToInt32(Console.ReadLine());
                    var res = (x + (j * k) - (k % y));
                    Console.WriteLine("  The result is: " + res);
                    break;
                case "g":
                    Console.WriteLine("Enter value of j in float :");
                    int u = Convert.ToInt32(Console.ReadLine());
                    x = Convert.ToInt32(u);
                    Console.WriteLine("  The value of X is: " + x);
                    break;
                case "h":
                    Console.WriteLine("  The value of X is: " + x);
                    x = x+3;
                    Console.WriteLine("  The value of X after adding 3 is: " + x);
                    x -= 5;
                    Console.WriteLine("  The value of X after decrement 5 is: " + x);
                    x++;
                    Console.WriteLine("  The value of X after increment operator is: " + x);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }

        }
    }
}
