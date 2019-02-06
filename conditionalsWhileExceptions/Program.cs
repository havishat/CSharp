using System;

namespace conditionalsWhileExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int i = 1;

            while(i <= 10){
                if( i % 2 == 0){
                    i++; i = i + 1;
                    
                }
            }

            Console.ReadLine();
        }
    }
}
