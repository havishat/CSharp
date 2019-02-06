using System;

namespace C_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            for(int i = 1; i < args.Length; i++){

                Console.WriteLine("arg {0} : {1}", i, args[i]);

            }

            SayHello();
            Console.ReadLine();
        }

        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }
    }
}
