using System;
using System.Linq;

namespace SpotyYT.Main.source
{
    public class Helper
    {
        public static string[] CommandLineArgs => Environment.GetCommandLineArgs().Skip(1).ToArray();
    }
}