using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            // int index = 1;
            // while(index <= 5)
            // {
            //     Console.WriteLine(index);
            //     index++;
            // }
            // Console.ReadLine();
            Console.WriteLine("\nWhat is your name?");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}");
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
