using System;

namespace CSharpTemplate.ConsoleProject;

internal class Program
{
    private static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Arguments not specified");
            return;
        }

        foreach (string arg in args)
        {
            Console.WriteLine(arg);
        }
    }
}
