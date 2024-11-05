using System;
using System.IO;
using FinalAssignment;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Please provide the path to the input file.");
            return;
        }

        string filePath = args[0];

        if (!File.Exists(filePath))
        {
            Console.WriteLine("The specified file does not exist.");
            return;
        }

        Solver.ProcessFile(filePath);
    }
}