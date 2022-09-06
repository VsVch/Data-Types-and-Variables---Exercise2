using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int person = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int count = 0;
            while (person > 0)
            {
                person = person - capacity;
                count++;
            }
            Console.WriteLine(count);

        }
    }
}
