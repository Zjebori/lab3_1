using System;

namespace week3ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Apples", "Banana", "Cucumber", };

            decimal[] prices = { 0.99m, 0.82m, 1.25m };
            int[] quantities = { 30, 25, 45};

            Console.WriteLine("Menu");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i} { names[i]}");
            }
            Console.WriteLine(" Enter a number for the item. or enter A to show all");
            string entry = Console.ReadLine();
            if (entry == "A")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine($"{i} {names[i]} {prices[i]} {quantities[i]}");
                }


            }
            else
            {
                int choice = int.Parse(entry);
                Console.WriteLine($"{ choice} { names[choice]} { prices[choice]} {quantities [choice]}");

            }
        }
    }
}
