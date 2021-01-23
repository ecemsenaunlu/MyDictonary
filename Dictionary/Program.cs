
using System;

namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictonary<string, int> dictonary = new Dictonary<string, int>();

            dictonary.Add("Ecem", 200);
            dictonary.Add("Mete", 300);
            dictonary.Add("Buse", 400);
            Console.WriteLine(dictonary.Count);

        }
    }
}