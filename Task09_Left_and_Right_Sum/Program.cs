using System;

namespace Task09_Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOne = 0;
            int sumTwo = 0;

            for (int i = 0; i < n; i++)
            {
                int nextDigit = int.Parse(Console.ReadLine());
                sumOne += nextDigit;
            }
            for (int i = 0; i < n; i++)
            {
                int nextDigit = int.Parse(Console.ReadLine());
                sumTwo += nextDigit;
            }
            if (sumOne == sumTwo)
            {
                Console.WriteLine($"Yes, sum = {sumOne}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumOne - sumTwo)}");
            }
        }
    }
}
