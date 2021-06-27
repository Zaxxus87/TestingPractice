using System;

namespace Testing_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayFun test = new ArrayFun(new int[] { -2, 2, 4 });
            Console.WriteLine(test.SumEvens());
            Console.WriteLine(test.SumPositive());
        }
    }
}
