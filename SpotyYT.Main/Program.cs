using System;
using System.Linq;
using SpotyYT.Main.source;

namespace SpotyYT.Main
{
    internal abstract class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello,");
            Console.WriteLine($"Arguments: {string.Join(", ", Helper.CommandLineArgs)}");
        }
    }
}