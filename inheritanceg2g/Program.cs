using System;


namespace inheritanceg2g
{

    class GFG {
        public string name;
        public string subject;

        public void readers(string name, string subject){
            this.name = name;
            this.subject = subject;
            Console.WriteLine("Myself: " + name);
            Console.WriteLine("My Favorite Subject is: " + subject);
        }
    }

    class GeeksforGeeks : GFG {

        public GeeksforGeeks(){
            Console.WriteLine("GeeksforGeeks");
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GeeksforGeeks g = new GeeksforGeeks();
            g.readers("kirti", "C#");
        }
    }
}
