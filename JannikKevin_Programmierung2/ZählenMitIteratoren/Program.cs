﻿using System;
using System.Collections.Generic;

namespace ZählenMitIteratoren
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int number in CountToTen())
            {
                Console.WriteLine(number);
            }
        }

        public static IEnumerable<int> CountToTen()
        {
            for (int i = 1; i <= 10; i++)
            {
                yield return i;
            }
        }
    }
}