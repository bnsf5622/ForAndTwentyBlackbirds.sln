using System;

namespace ForAndTwentyBlackbirds.sln
{
    class Program
    {
        static void Main(string[] args)
        {
            int birdsInPie = 0;
                for (int i = 0; i < 2000000; i++)
            {
                Console.WriteLine("Blackbird #" + i + " goes into the pie");
                birdsInPie++;


            }

            Console.WriteLine("There are " + birdsInPie + " birds in there!");
            Console.WriteLine("Quite the pie is full");
        }
    }
}