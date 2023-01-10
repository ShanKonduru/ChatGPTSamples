using System;

class PrimeChecker
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int n = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;

        if (n == 1 || n == 0)
        {
            Console.WriteLine(n + " is not a prime number.");
            return;
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            Console.WriteLine(n + " is a prime number.");
        }
        else
        {
            Console.WriteLine(n + " is not a prime number.");
        }
    }
}
