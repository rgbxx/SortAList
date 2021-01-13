using System;
using System.Collections.Generic;

namespace SortAList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> test = new List<int>(){ 999, -53, 54, 32, 12, 43, 1, 1, 2, 0, 65, -32, 1};
            Console.WriteLine(String.Join(", ", test));
            Console.WriteLine(String.Join(", ", SortList(test)));
        }

        static List<int> SortList(List<int> input)
        {
            input.Sort();
            return input;
        }
    }
}
