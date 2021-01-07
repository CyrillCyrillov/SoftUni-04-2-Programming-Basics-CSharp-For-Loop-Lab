using System;

namespace Task11_Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int toys = 0;
            double money = 0;
            int year = int.Parse(Console.ReadLine());
            double priceOfWashingMachine = double.Parse(Console.ReadLine());
            double pricePerToy = double.Parse(Console.ReadLine());
            for (int i = 1; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    sum += ((i * 5) - 1);
                }
                else
                {
                    toys += 1;
                }
            }
            money = sum + (toys * pricePerToy);
            if (money < priceOfWashingMachine)
            {
                Console.WriteLine($"No! {(priceOfWashingMachine - money):F2}");
            }
            else
            {
                Console.WriteLine($"Yes! {(money - priceOfWashingMachine):F2}");
            }
        }
    }
}
