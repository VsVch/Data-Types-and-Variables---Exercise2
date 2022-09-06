using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());

            int sumFS = first + second;
            int devOp = sumFS / third;
            int multy = devOp * fourth;

            Console.WriteLine(multy);
        }
    }
}
