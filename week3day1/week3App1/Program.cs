using System;

namespace week3App1
{
    class Program
    {
        static Decimal Average(decimal[] number)
        {

            decimal result = 0;
            for (int i = 0; i <= number.Length -1; i++)
            {
                result += number[i];

            }
            result = result / number.Length;
            return result;

        
        
        
        }


        static void Main(string[] args)
        {
            decimal[] prices = { 12.00m, 10.00m, 13.50m, 6.99m, 12.05m, 19.99m };

            decimal avg = (prices[0] + prices[1] + prices[2] + prices[3] + prices[4] + prices[5]) / 6;

            Console.WriteLine(avg);

            decimal realavg = 0;
            for (int i = 0; i < prices.Length; i++)
            {

                realavg = realavg + prices[i];

            }

            realavg = realavg / prices.Length;
            Console.WriteLine(realavg);

        }

    }
}
