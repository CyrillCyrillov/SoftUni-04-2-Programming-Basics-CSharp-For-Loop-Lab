using System;

namespace Task06_Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int n = word.Length;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char letter = word[i];
                if (letter == 'a')
                {
                    sum = sum + 1;
                }
                else if (letter == 'e')
                {
                    sum = sum + 2;
                }
                else if (letter == 'i')
                {
                    sum = sum + 3;
                }
                else if (letter == 'o')
                {
                    sum = sum + 4;
                }
                else if (letter == 'u')
                {
                    sum = sum + 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
