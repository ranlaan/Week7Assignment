﻿using System;

namespace DuckSong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Five Little Ducks");
            string ducks;
            for (int i = 5; i > 0; i--)
            {
                if (i > 2)
                {
                    ducks = "ducks";
                }
                else
                {
                    ducks = "duck";
                }

                Console.WriteLine($"{i} little {ducks} went out one day");
                Console.WriteLine("Over the hill far away");
                Console.WriteLine("Mother duck said, Quack, quack, quack, quack \"");

                if (i == 2)
                {
                    ducks = "duck";
                }
                if (i > 1)
                {
                    Console.WriteLine($"But only {i - 1} little {ducks} came back");
                }
                else
                {
                    Console.WriteLine($"But none of the {i + 4} little ducks came back");
                }
                Console.WriteLine();
            }
        }
    }
}
