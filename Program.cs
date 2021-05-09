using System;
using Humanizer;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TimeSpan.FromMilliseconds(1234557464).Humanize());
            Console.WriteLine(TimeSpan.FromMilliseconds(847362426283).Humanize(3));
            Console.WriteLine(TimeSpan.FromMilliseconds(6353426283).Humanize(4));
        }
    }
}
