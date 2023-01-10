using System;

class FibonacciFinder
{
    static void Main(string[] args)
    {
        long first = 0;
        long second = 1;
        long fibonacci;
        int n = 50;

        Console.WriteLine(first);
        Console.WriteLine(second);

        for (long i = 2; i < n; i++)
        {
            fibonacci = first + second;
            Console.WriteLine(fibonacci);
            first = second;
            second = fibonacci;
        }

        Console.WriteLine("The "+n+"th Fibonacci number is: " + second);
    }
}
