using System;

namespace q58
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of A :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of B :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of C:");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Which one,, Do you want to Execute (a,b,c,d,e,f,g,h,i)");
            string problemNumber = Console.ReadLine();
            Console.WriteLine("Problem # " + problemNumber + " is going to Execute");
            switch (problemNumber)
            {
                case "a":
                    try
                    {
                        ++a;
                        Console.WriteLine("The result is valid and value of a: " + a + "  value of B:" + b + "  value of C:" + c);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("The result is invalid");
                    }
                   
                    break;
                case "b":
                    try
                    {
                        Console.WriteLine("The result is invalid");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("The result is invalid");
                    }
                    break;
                case "c":
                    try
                    {
                        a++;
                        Console.WriteLine("The result is valid and value of a: " + a + "  value of B:" + b + "  value of C:" + c);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("The result is invalid");
                    }
                    a++;
                    Console.WriteLine("The result is valid and value of a: " + a + "  value of B:" + b + "  value of C:" + c);
                    break;
                case "d":
                    try
                    {
                        b += a;
                        Console.WriteLine("The result is valid and value of a: " + a + "  value of B:" + b + "  value of C:" + c);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("The result is invalid");
                    }

                    
                    break;
                case "e":
                    try
                    {
                        b += a * c;
                        Console.WriteLine("The result is valid and value of a: " + a + "  value of B:" + b + "  value of C:" + c);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("The result is invalid");
                    }
                   
                    break;
                    
                case "f":
                    try
                    {
                        Console.WriteLine("The result is invalid");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("The result is invalid");
                    }
                    break;
                case "g":
                    try
                    {
                        c=a*b;
                        Console.WriteLine("The result is valid and value of a: " + a + "  value of B: " + b + "  value of C: " + c);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("The result is invalid");
                    }
                    break;
                case "h":
                    try
                    {
                        ++b;
                        Console.WriteLine("The result is valid and value of a: " + a + "  value of B: " + b + "  value of C: " + c);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"The result is invalid{e.Message}");
                    }
                    break;
                case "i":
                    try
                    {
                        b = a++ + b++;
                        Console.WriteLine("The result is valid and value of a: " + a + "  value of B: " + b + "  value of C: " + c);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("The result is invalid");
                    }
                    break;

                default:
                    Console.WriteLine("Pls enter right value");
                    break;
            }

        }
    }
}
