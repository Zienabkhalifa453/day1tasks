﻿using System;
namespace ConsoleApp2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a>=1 && a<=10)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}