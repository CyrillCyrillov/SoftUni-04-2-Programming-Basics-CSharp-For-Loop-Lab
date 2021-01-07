using System;

namespace Task07_Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= numbers; i++)
            {
                int nextDigit = int.Parse(Console.ReadLine());
                sum = sum + nextDigit;
            }
            
            Console.WriteLine(sum);
        }
    }
}
