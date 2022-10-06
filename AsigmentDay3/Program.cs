using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Task.WhenAny(
            GetPrimeNumbers(0, 100),
            GetPrimeNumbers(100, 200)
        );

        Console.WriteLine("Task done");
        Console.ReadKey();
    }
    static async Task GetPrimeNumbers(int minimum, int maximum)
    {
        await Task.Run(() =>
        {
            for (int i = minimum; i <= maximum; i++)
            {
                if (IsPrimeNumber(i))
                {
                    Console.WriteLine(" " + i);
                }
            }
        });
    }
    static bool IsPrimeNumber(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i < number / 2; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}