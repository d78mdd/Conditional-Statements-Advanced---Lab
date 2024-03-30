using System;

namespace _05.Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string produkt = Console.ReadLine();
            string grad = Console.ReadLine();
            double kolichestvo = double.Parse(Console.ReadLine());

            double totalLocalPrice = 0.0;

            switch (grad)
            {
                case "Sofia":
                    switch (produkt)
                    {
                        case "coffee":
                            totalLocalPrice = 0.5 * kolichestvo;
                            break;
                        case "water":
                            totalLocalPrice = 0.8 * kolichestvo;
                            break;
                        case "beer":
                            totalLocalPrice = 1.2 * kolichestvo;
                            break;
                        case "sweets":
                            totalLocalPrice = 1.45 * kolichestvo;
                            break;
                        case "peanuts":
                            totalLocalPrice = 1.6 * kolichestvo;
                            break;

                        default:
                            totalLocalPrice = 0.0;
                            break;
                    }
                    Console.WriteLine(totalLocalPrice);
                    break;

                case "Plovdiv":
                    switch (produkt)
                    {
                        case "coffee":
                            totalLocalPrice = 0.4 * kolichestvo;
                            break;
                        case "water":
                            totalLocalPrice = 0.7 * kolichestvo;
                            break;
                        case "beer":
                            totalLocalPrice = 1.15 * kolichestvo;
                            break;
                        case "sweets":
                            totalLocalPrice = 1.3 * kolichestvo;
                            break;
                        case "peanuts":
                            totalLocalPrice = 1.5 * kolichestvo;
                            break;

                        default:
                            totalLocalPrice = 0.0;
                            break;
                    }
                    Console.WriteLine(totalLocalPrice);
                    break;

                case "Varna":
                    switch (produkt)
                    {
                        case "coffee":
                            totalLocalPrice = 0.45 * kolichestvo;
                            break;
                        case "water":
                            totalLocalPrice = 0.7 * kolichestvo;
                            break;
                        case "beer":
                            totalLocalPrice = 1.1 * kolichestvo;
                            break;
                        case "sweets":
                            totalLocalPrice = 1.35 * kolichestvo;
                            break;
                        case "peanuts":
                            totalLocalPrice = 1.55 * kolichestvo;
                            break;

                        default:
                            totalLocalPrice = 0.0;
                            break;
                    }
                    Console.WriteLine(totalLocalPrice);
                    break;
            }

        }
    }
}
