using System;
using System.Collections.Generic;
using System.IO;

namespace SearchStringInTextFile
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var found = new List<string>();
            var firstTwoCharacters = new List<string>();

            using (var file = new StreamReader("E:\\Test.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                    if (line.Substring(0, 1).Contains("3"))
                        found.Add(line);
            }

            foreach (var item in found) Console.WriteLine(item);

            Console.ReadKey();

            //foreach (var item in found)
            //{
            //    var firstTwoChar = item.Substring(0, 2);
            //    firstTwoCharacters.Add(firstTwoChar);
            //}

            //var distinct = firstTwoCharacters.Distinct().ToList();

            //foreach (var value in distinct) Console.WriteLine(value);
            //Console.ReadKey();
        }
    }
}