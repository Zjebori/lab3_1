using System;

namespace week3day1
{
    class Program
    {

        static string Reverse(string str) 
        {
            string rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {

                rev += str[i];
            }
            return rev;
       
        }

        static void Main(string[] args)
        {
            string test = "hello";
            string test2 = Reverse(test);
            Console.WriteLine(test2);
        }
    }
}
