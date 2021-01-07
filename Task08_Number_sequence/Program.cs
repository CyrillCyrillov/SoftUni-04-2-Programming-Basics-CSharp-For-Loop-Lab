using System;

namespace Task08_Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < numbers; i++)
            {
                int nextDigit = int.Parse(Console.ReadLine());
                if (nextDigit >= max)
                {
                    max = nextDigit;
                }
               if (nextDigit <= min)
                {
                    min = nextDigit;
                }
            }
            
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
