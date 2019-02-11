using System;

namespace printaPyramid
{
    class Program
    {
        public static void Main (string[] args) {
        Console.WriteLine ("Hello World");
        start();


  }

  public static void start(){
    int v = 20;
    for(int row = 1; row < 10; row++){
      for(int j=1; j<v; j++){
        Console.Write(" ");
      }
      v = v - 1;
      for(int column = 1; column < row*2; column++){
        Console.Write("*");
      }
      Console.WriteLine();
    }

    // return
  }

}
