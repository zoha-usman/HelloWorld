using System;

namespace q59
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of A :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of B :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of P :");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of Q :");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of N :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Which one,, Do you want to Execute (a,b,c,d,e,f,g,h,i,k)");
            string problemNumber = Console.ReadLine();
            Console.WriteLine("Problem # " + problemNumber + " is going to Execute");
            switch (problemNumber)
            {
                case "a":
                    var res1 = 22/8;
                    Console.WriteLine("The result is : " + res1);
                    break;
                case "b":
                    var res2 = ((99/8)+((21/11)*7));
                    Console.WriteLine("The result is : " + res2);
                    break;
                case "c":
                    var res3 = (q/a)-(p/b) ;
                    Console.WriteLine("The result is : " + res3);
                    break;
                case "d":
                    var res4 = (p / a) - (q / b);
                    Console.WriteLine("The result is : " + res4);
                    break;
                case "e":
                    var res5 = (p / b) - (q / a);
                    Console.WriteLine("The result is : " + res5);
                    break;
                case "f":
                    int res6 = (11 + (7 / 4) + ((98 %6) * 3));
                    Console.WriteLine("The result is : " + res6);
                    break;
                case "g":
                    int res7 =(((11/31)%8)*5)-12;
                    Console.WriteLine("The result is : " + res7);
                    break;
                case "h":
                    var res8 = (q*p)+(3.0*p*p)-((p%3)*p*p*p);
                    Console.WriteLine("The result is : " + res8);
                    break;
                case "i":
                    var res9 = ((q%2)*p)+(6.0*p*(q%3))+((q%4) * p * p * p);
                    Console.WriteLine("The result is : " + res9);
                    break;
                case "j":
                    n *= a + b;
                    a--;
                    n %= a;
                    Console.WriteLine("The result is : " + n);
                    break;
                case "":
                    int c;
                    ++n;
                    a = -n;
                    n = n - a;
                    Console.WriteLine("The result is : " + n);
                    break;
                default:
                    Console.WriteLine("Pls enter right value");
                    break;
            }
        }
    }
}
