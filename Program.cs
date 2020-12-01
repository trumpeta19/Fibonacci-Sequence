using System;

namespace Fibonacci_Sequence
{
    class Program
    {
        static void PrintSequence(int digits)
        {
            int a = 0; // variable to hold Fibonacci numbers
            int b = 1; // variable to hold Fibonacci numbers

            Console.WriteLine();
            for (int i = 1; i <= digits; i += 2)
            {
                Console.WriteLine(a);
                if (i != digits)
                {
                    Console.WriteLine(b);
                }
                a += b; // 1; 3; 8
                b += a; // 2; 5; 13
            }
        }
        static void Main()
        {
            const int MAX = 32;
            int digits;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Enter number of digits in Fibonacci sequence to print ");

                if (int.TryParse(Console.ReadLine(), out digits))
                {
                    if (digits > MAX)
                    {
                        PrintSequence(MAX);
                        Console.WriteLine("Number too high. Max value (" + MAX + ") printed");

                    }
                    else if (digits < 1)
                    {
                        PrintSequence(1);
                        Console.WriteLine("Number too low. First value printed");
                    }
                    else
                    {
                        PrintSequence(digits);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                }

                Console.WriteLine("Press any key to continue or 'Esc' to quit");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
