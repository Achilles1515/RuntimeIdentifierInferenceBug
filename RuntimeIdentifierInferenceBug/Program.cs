using Microsoft.RE2.Managed;
using System;

namespace RuntimeIdentifierInferenceBug
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Regex2.Test();
            Console.WriteLine("Regex2.Test() --> success");
            Console.ReadKey();
        }
    }
}
