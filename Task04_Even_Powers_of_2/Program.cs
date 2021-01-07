using System;

namespace Task04_Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double number = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    number = Math.Pow(2, i);
                    Console.WriteLine(number);
                }
            }
        }
    }
}
