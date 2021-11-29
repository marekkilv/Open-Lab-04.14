using System;

namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {
            string[] words = new[] { "Hello", "World", "in", "a", "frame" };
        int length = 0;

        foreach (var item in words)
        {
            if (length < item.Length)
            {
                length = item.Length;
            }            
        }
        String tabs = new string('*', length + 4);

        Console.WriteLine(tabs);
        foreach (var item in words)
        {
            Console.WriteLine("* " + item.PadRight(length, ' ') + " *");
        }
        Console.WriteLine(tabs);
        Console.ReadKey();

        }
    }
}