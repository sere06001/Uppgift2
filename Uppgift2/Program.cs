using System;
using System.Collections.Generic;
namespace uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(100);
            list.Add(4);
            list.Add(5);
            Console.WriteLine("Största talet i listan: " + Max(list));
            Console.ReadKey();
        }
        static int Max(List<int> list)
        {
            list.Sort();
            return list[list.Count-1];
        }
    }
}