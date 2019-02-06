using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] numbers = new int[5];

            // numbers[0] = 4;
            // numbers[1] = 8;
            // numbers[2] = 15;
            // numbers[3] = 16;
            // numbers[4] = 23;

            // Console.WriteLine(numbers[1]);
            // Console.WriteLine(numbers.Length);
            // Console.ReadLine();

            // int[] numbers = new int[] {4,8,15,16,23,42};

            string[] names = new string[] {"Eddie", "Alex", "Michael", "David Lee"};

            // for (int i = 0; i<names.Length; i++){
            //     Console.WriteLine(names[i]);
            // }
            // Console.ReadLine();

            // foreach (var name in names)
            // {
            //     Console.WriteLine(name);
            // }

            // Console.ReadLine();
            
            string zig = "You can get what you want out of life" + "if you help enough other people get what they want.";

            char[] charArray = zig.ToCharArray();

            Array.reverse(charArray);

            foreach (char zigChar in charArray){
                Console.Write(zigChar);
            }

            int[] favNums = new int[3];

            favNums[0] = 23;

            Console.WriteLine("favNum 0 : {0}", favNum[0]);

            string[] customers = { "Bob", "Sally", "Sue"};

            var employees = new[] { "Mike", "Paul", "Rick"};

            object[] randomArray = { "Paul", 45, 1.234};

            Console.WriteLine("randomArray 0 : {0}")

            Console.ReadLine();


        }
    }
}
