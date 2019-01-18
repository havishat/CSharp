using System;

namespace function
{
    // public delegate int SomeOperation(int i, int j);
    class Program
    {
        // static int Sum(int x, int y){
        //     return x + y;
        // }

        static bool IsUpperCase(string str){
            return str.Equals(str.ToUpper());
        }

        static void Main(string[] args)
        {
            Predicate<string> IsUpper = IsUpperCase;

            bool result = IsUpper("HELLOW!");
            Console.WriteLine(result);
            // SomeOperation add = Sum;
            // int restult = add(10, 10);
            // Console.WriteLine("Hello World!");
            // Console.WriteLine(restult);
        }
    }
}
