using System;

class PrimeFinder
{
    static void Main(string[] args)
    {
        int primeCounter = 0;
        int currentNumber = 2;
        int nthPrimeNumber = 10001;

        while (primeCounter < nthPrimeNumber)
        {
            if (IsPrime(currentNumber))
            {
                primeCounter++;
            }

            currentNumber++;
        }

        Console.WriteLine("The " + nthPrimeNumber + "th prime number is " + (currentNumber-1));
    }

    static bool IsPrime(int n)
    {
        if (n == 1 || n == 0)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
}
