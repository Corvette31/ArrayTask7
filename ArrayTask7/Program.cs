﻿using System;

namespace ArrayTask7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");

            foreach (var item in Console.ReadLine().Split())
            {
                Console.WriteLine(item);
            }
        }
    }
}
