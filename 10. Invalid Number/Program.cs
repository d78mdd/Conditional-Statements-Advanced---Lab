using System;

namespace _10.Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo = int.Parse(Console.ReadLine());

            if ((chislo < 100 && chislo != 0) || chislo > 200)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
