using System;

namespace Task05_Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int symbols = word.Length;

            for (int i = 0; i < symbols; i++)
            {
                char letter = word[i];
                Console.WriteLine(letter);
            }
        }
    }
}
