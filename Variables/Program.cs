﻿using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // int x;
            // int y;
            // x = 7;
            // y = x + 3;
            // Console.WriteLine(y);
            // Console.ReadLine();

            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();
            // x = Console.ReadLine();

            string myLastName;
            Console.Write("Type your last name: ");
            myLastName = Console.ReadLine();

            Console.WriteLine("Hello," + myFirstName + " " + myLastName);

            // Console.WriteLine("Hello," + x + " " + myLastName);
            Console.ReadLine();

        }
    }
}
