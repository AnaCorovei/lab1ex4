using System;

namespace lab1ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex4
            Scrieti un program care va afisa semnul unui numar citit de la tastatura
            • Daca numarul este pozitiv, va afisa “+”
            • Daca numarul este negativ, va afisa “-”
            • Daca numarul este 0, va afisa “0”*/

            long number;

            Console.WriteLine("Enter the number: ");
            number = long.Parse(Console.ReadLine());

            if (number > 0)
            Console.WriteLine("The number is positive");

            else if (number < 0)
            {
                Console.WriteLine("The number is negative");
            }

            else if (number == 0)
            { 
                Console.WriteLine(0);
            }
        }
    }
}
