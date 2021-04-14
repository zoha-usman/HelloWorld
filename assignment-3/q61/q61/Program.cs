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
                Console.WriteLine("Enter value of C :");
                int c= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value of D :");
                int d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value of E :");
                int e = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Which one,, Do you want to Execute (a,b,c)");
                string problemNumber = Console.ReadLine();
                Console.WriteLine("Problem # " + problemNumber + " is going to Execute");
                switch (problemNumber)
                {
                    case "a":
                        var res1 = (a+(b/(c-5)))/(((d+7)/(e-37))%3);
                        Console.WriteLine("The result is : " + res1);
                        break;
                    case "b":
                        var res2 =(a+(b/c)-(5/d)+(7/e)-(37%3));
                        Console.WriteLine("The result is : " + res2);
                        break;
                    case "c":
                        var res3 =((a*(b*b))-(c*d))+d ;
                        Console.WriteLine("The result is : " + res3);
                        break;
                    default:
                        Console.WriteLine("Pls enter right value");
                        break;
                }
            }
        }
    }

