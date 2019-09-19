﻿using System;
using DataStructures.Algorithms;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bubble sort the following numbers 10,5,6,9,14,2");
            int[] numberArray = { 10, 5, 6, 9, 14, 2 };
            var Bubble = new BubbleSort();
            Bubble.SortArray(numberArray);
            foreach (int number in numberArray)
            {
                Console.Write($" { number }");
            }
            Console.WriteLine("");
        }
    }
}
