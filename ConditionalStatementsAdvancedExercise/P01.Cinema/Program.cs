﻿namespace P01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            double price = 0;
            if (type == "Premiere")
            {
                price = 12;
            }
            else if (type == "Normal")
            {
                price = 7.50;
            }
            else if (type == "Discount")
            {
                price = 5;
            }

            double totalSum = rows * cols * price;
            Console.WriteLine($"{totalSum:f2} leva");
        }
    }
}
