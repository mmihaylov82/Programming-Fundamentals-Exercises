﻿using System;

namespace _14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            string skip = Console.ReadLine();

            for (char i = first; i <= second ; i++)
            {
                for (char j = first; j <= second; j++)
                {
                    for (char k = first; k <= second; k++)
                    {
                        string result = $"{i}{j}{k} ";
                        if (!result.Contains(skip))
                        {
                            Console.Write(result);
                        }
                    }
                }
            }
        }
    }
}