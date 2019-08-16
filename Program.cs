using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxProfit();
            
        }

        public static int MaxProfit()
        {
            int[] stocks = { 9, 11, 8, 5, 7, 10, 1, 2, 3, 4 };
            int profit = 0;
            for (int i = 0; i < stocks.Length; i++)
            {
                for (int i2 = i + 1; i2 < stocks.Length; i2++)
                {
                    if ((stocks[i2] - stocks[i]) > profit)
                    {
                        profit = (stocks[i2] - stocks[i]);
                    }
                }
            }
            Console.WriteLine(profit);
            return profit;
        }// 
    }
}