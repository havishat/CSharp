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

                if( i == 9) break;

                Console.WriteLine(i);
                i++;
            }

            Console.ReadLine();
        }
    }
}
