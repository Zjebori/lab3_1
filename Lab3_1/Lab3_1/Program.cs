using System;

namespace Lab3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which Student would you like to learn more about? (0-2)");

            string[] names = { "zaid", "ali", "zainab", };

            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(names[input]);

            Console.WriteLine("What would you like to know about" +" " + names[input] + "(enter 0  for “favorite food” or 1 “previous title”:");

            int zaids = int.Parse(Console.ReadLine());

            string[] zaidfood = { "Pizza", "Banker",};

            Console.WriteLine(zaidfood[zaids]);






            //fav = (true);

            //if fav(true);
            //{
            //    string[] Food = { "pizza", "candy", "coffee" };
            //}

            //else
            //{
            //    string[] previousjob = { "banker", "baby", "Insurance" };
            //}
            //int fav = int.Parse(Console.ReadLine());
            //Console.WriteLine("value is: " + Food[fav]);




            //if (true)
            //{
            //    string[] Food = { "pizza", "candy", "coffee" };

            //    Console.WriteLine("value is: " + Food[input]);

            //}
            //else
            //{

            //    string[] previousjob = { "banker", "baby", "Insurance" };

            //    Console.WriteLine("value is: " + previousjob[input]);

            //}



            //for (int i = 0; i <= 4 ; i++)
            //{
            //    Console.ReadLine();
            //}

            //string[] Food = { "pizza", "candy", "coffee" };

            //string[] previousjob = { "banker", "baby", "Insurance" };

            //Console.WriteLine( names[]);

        }
    }
}
