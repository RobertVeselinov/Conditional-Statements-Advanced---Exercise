using System;

namespace P06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            double result = 0;


            if (symbol == '+')
            {
                result = n1 + n2;
            }
            else if (symbol == '-')
            {
                result = n1 - n2;
            }
            else if (symbol == '*')
            {
                result = n1 * n2;
            }
            else if (symbol == '/')
            {
                result = (double)n1 / (double)n2;
            }
            else if (symbol == '%' && n2 != 0)
            {
                    result = n1 % n2;
            }

            if (symbol == '+' && result % 2 == 0)
            {
                Console.WriteLine($"{n1} + {n2} = {result} - even");
            }
            else if (symbol == '+' && result % 2 != 0)
            {
                Console.WriteLine($"{n1} + {n2} = {result} - odd");
            }
            else if (symbol == '-' && result % 2 == 0)
            {
                Console.WriteLine($"{n1} - {n2} = {result} - even");
            }
            else if (symbol == '-' && result % 2 != 0)
            {
                Console.WriteLine($"{n1} - {n2} = {result} - odd");
            }
            else if (symbol == '*' && result % 2 == 0)
            {
                Console.WriteLine($"{n1} * {n2} = {result} - even");
            }
            else if (symbol == '*' && result % 2 != 0)
            {
                Console.WriteLine($"{n1} * {n2} = {result} - odd");
            }
            else if (symbol == '/')
            {
                if (n2 != 0)
                {
                    Console.WriteLine($"{n1} / {n2} = {result:f2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
            }
            else if (symbol == '%')
            {
                if (n2 != 0)
                {
                    Console.WriteLine($"{n1} % {n2} = {result}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
            }
        }
    }
}
