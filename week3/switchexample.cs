using System;

namespace week3lab2
{
    class switchexample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number 1-5");
            string entry = Console.ReadLine();

            switch (entry)
            {
                case "1":
                    Console.WriteLine("you entered one");
                    break;

                case "2":
                    Console.WriteLine("you entered two");
                    break;
                case "3":
                    Console.WriteLine("you entered three");
                    break;
                case "4":
                    Console.WriteLine("you entered four");
                    break;
                case "5":
                    Console.WriteLine("you entered five");
                    break;
                default:
                    Console.WriteLine("you entered something else");
                    break;












            }
        }
    }
}
