using System;

namespace _12.Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {

            string grad = Console.ReadLine();
            double prodajbi = double.Parse(Console.ReadLine());

            double komisionna = 0.0;

            switch (grad)
            {
                case "Sofia":

                    if (0 <= prodajbi && prodajbi <= 500)
                    {
                        komisionna = 0.05 * prodajbi;
                    }
                    else if (500 < prodajbi && prodajbi <= 1000)
                    {
                        komisionna = 0.07 * prodajbi;
                    }
                    else if (1000 < prodajbi && prodajbi <= 10000)
                    {
                        komisionna = 0.08 * prodajbi;
                    }
                    else if (prodajbi > 10000)
                    {
                        komisionna = 0.12 * prodajbi;
                    } else
                    {
                        Console.WriteLine("error");
                        return;
                    }
                    break;

                case "Varna":

                    if (0 <= prodajbi && prodajbi <= 500)
                    {
                        komisionna = 0.045 * prodajbi;
                    }
                    else if (500 < prodajbi && prodajbi <= 1000)
                    {
                        komisionna = 0.075 * prodajbi;
                    }
                    else if (1000 < prodajbi && prodajbi <= 10000)
                    {
                        komisionna = 0.10 * prodajbi;
                    }
                    else if (prodajbi > 10000)
                    {
                        komisionna = 0.13 * prodajbi;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        return;
                    }
                    break;

                case "Plovdiv":

                    if (0 <= prodajbi && prodajbi <= 500)
                    {
                        komisionna = 0.055 * prodajbi;
                    }
                    else if (500 < prodajbi && prodajbi <= 1000)
                    {
                        komisionna = 0.08 * prodajbi;
                    }
                    else if (1000 < prodajbi && prodajbi <= 10000)
                    {
                        komisionna = 0.12 * prodajbi;
                    }
                    else if (prodajbi > 10000)
                    {
                        komisionna = 0.145 * prodajbi;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        return;
                    }
                    break;

                default:
                    Console.WriteLine("error");
                    return;
            }

            string komisionnaFormatted = komisionna.ToString("F2");

            Console.WriteLine(komisionnaFormatted);

        }
    }
}
