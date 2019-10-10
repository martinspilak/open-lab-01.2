using System;

namespace open_lab_01._2
{
    class Program
    {
        public static int sum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
         
          Console.WriteLine(sum(a, b));
        }
    }
}
