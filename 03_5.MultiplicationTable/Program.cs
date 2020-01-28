﻿using System;

namespace _03_5.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] multiplication = new int[10,10];

            for (int i = 0; i < multiplication.GetLength(0); i++)
            {
                int num = 1;
                for (int j = 0; j < multiplication.GetLength(1); j++)
                {
                    multiplication[i,j] = num * (i + 1);
                    num++;
                }
            }
        }
    }
}
