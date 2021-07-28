using System;

namespace Assetment
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Welcome, would you like to draw a triangle or a rectangle?: ");
                string choice = Console.ReadLine();
                if (choice == "triangle")
                {
                    Console.WriteLine("left or right");
                    string Left= Console.ReadLine();

                    if (Left == "left")
                    {

                        Console.Write("Enter a height: ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        int i, j, k;
                        for (i = 1; i <= number; i++)
                        {
                            for (j = 1; j <= number - i; j++)
                            {
                                Console.Write("");
                            }

                            for (k = 1; k <= i; k++)
                            {
                                Console.Write("*");
                            }

                            Console.WriteLine("");
                        }


                    }


                    
                    string right = Console.ReadLine();

                    if (right == "")
                    {

                        Console.Write("Enter a height: ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        int i, j, k;
                        for (i = 1; i <= number; i++)
                        {
                            for (j = 1; j <= number - i; j++)
                            {
                                Console.Write("");
                            }

                            for (k = 1; k <= i; k++)
                            {
                                Console.Write("*");
                            }

                            Console.WriteLine("");
                        }


                    }
                }

                else if (choice == "rectangle")
                {
                    Console.Write("Enter a width: ");
                    int width = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter a height: ");
                    int height = Convert.ToInt32(Console.ReadLine());
                    for (int r = 0; r < height; r++)
                    {
                        for (int c = 0; c < width; c++)
                        {
                            Console.WriteLine("*");
                           

                        }
                    }
                }
                Console.Write("\nWould you like to draw another shape? (y/n): ");
                string answer = Console.ReadLine();
                if (answer == "n")
                {
                    Console.Write("Goodbye!\n");
                }
                else if (answer == "y")
                {
                    Console.WriteLine();
                    continue;
                }
                else if (answer != "y" || answer != "n")
                {
                    Console.WriteLine("Sorry, invalid input");
                }
                break;
            }
            while (true);

        }
    }
}
