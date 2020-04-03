using System;

namespace Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Characters - single alphabet or number or symbol
            Console.WriteLine("-- C# Characters --");
            char c = 'a';
            char d = '5';
            char s = '*';
            // Character takes 2 bytes of memory
            Console.WriteLine(sizeof(char));

            // C# Strings - collection or sequence of characters
            Console.WriteLine("-- C# Strings --");
            string name = "value";
            string another = "hello";
            Console.WriteLine(name);
        }
    }
}
