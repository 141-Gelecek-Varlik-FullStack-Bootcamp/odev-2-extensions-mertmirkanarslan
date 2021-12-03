using System;

namespace Extensions.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime zaman = DateTime.Now;
            Console.WriteLine("Turkish Time at GMT+3 is:");
            Console.WriteLine(zaman.ToString());
            Console.WriteLine("Turkish Time at GMT+2 is:");
            Console.WriteLine(Homework_2.Core.Extensions.ToOldDateTime(zaman));
        }
    }
}