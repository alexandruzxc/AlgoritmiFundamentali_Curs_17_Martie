﻿using System;

namespace Palindrom
{
    class Program
    {
        public static bool IsPalindrom(int n)
        {
            int og = 0;
            int cn = n;
            while (n != 0)
            {
                og = og * 10 + n % 10;
                n = n / 10;
            }
            if (og == cn)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');

            int[] v = new int[n];


            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
                if (IsPalindrom(v[i]))
                    Console.Write(v[i] + " ");

            }

        }
    }
}
