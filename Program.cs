using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace Collection_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = Stopwatch.StartNew();

            string text = File.ReadAllText("C:\\Users\\Роман\\Desktop\\cdev_Text.txt");

            char[] chars = text.ToCharArray();

            List<char> list = new List<char>(chars);

            Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);

            ///////////////////////////////////////////////////////////////////////

            var stopWatch1 = Stopwatch.StartNew();

            string text1 = File.ReadAllText("C:\\Users\\Роман\\Desktop\\cdev_Text.txt");

            char[] chars1 = text.ToCharArray();

            LinkedList<char> list1 = new LinkedList<char>(chars);

            Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);

        }
    }
}
