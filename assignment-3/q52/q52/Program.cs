using System;

namespace q52
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Which one,, Do you want to Execute (a,b,c,d,e,f,g)");
            string problemNumber = Console.ReadLine();
            Console.WriteLine("Problem # " + problemNumber + " is going to Execute");
            switch (problemNumber)
            {
                case "a":
                    int res1 = (((1 + 8) / 2)+((1*4)+(5*4))/4);
                    Console.WriteLine("The result is : " + res1);
                    break;
                case "b":
                    int res2 = (((1+1+1+1)/2)+((1+1+1)/3));
                    Console.WriteLine("The result is : " + res2);
                    break;
                case "c":
                    int res3 = ((((5*5)+5)/5)+6);
                    Console.WriteLine("The result is : " + res3);
                    break;
                case "d":
                    int res4 = (((3+4)+(4*7))/5);
                    Console.WriteLine("The result is : " + res4);
                    break;
                case "e":
                    int res5 = ((3*6*7*2)+(12/2));
                    Console.WriteLine("The result is : " + res5);
                    break;
                case "f":
                    int res6 = (((5-3)*4)%(6-1));
                    Console.WriteLine("The result is : " + res6);
                    break;
                case "g":
                    int res7 = (((8*4*2)+6)/2)+4);
                    Console.WriteLine("The result is : " + res7);
                    break;
                default:
                    Console.WriteLine("Pls enter right value");
                    break;
            }
        }
    }
}
