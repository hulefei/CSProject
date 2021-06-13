using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace CSProject.Chapter06
{
    public static class Main
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("Chapter06");
            // Test1();
            // Test2();
            // Test3();

            // Test4();
            Test5();
        }

        private static void Test5()
        {
            var readLines = ReadLines(@"../../line.txt");
            foreach (var line in Where(readLines, s => s.StartsWith("a")))
            {
                Console.WriteLine(line);
            }
        }

        public static IEnumerable<T> Where<T>(IEnumerable<T> source, Predicate<T> predicate)
        {
            if (source == null || predicate == null)
            {
                throw new ArgumentException();
            }

            return WhereImpl(source, predicate);
        }

        private static IEnumerable<T> WhereImpl<T>(IEnumerable<T> source, Predicate<T> predicate)
        {
            // return source.Where(item => predicate(item));
            
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }

        private static void Test4()
        {
            var readLines = ReadLines(@"../../line.txt");
            foreach (var line in readLines)
            {
                Console.WriteLine(line);
            }
        }

        private static IEnumerable<string> ReadLines(string filename)
        {
            using (TextReader reader = File.OpenText(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }

        private static void Test3()
        {
            using (var d = new DisposeObject())
            {
                Console.WriteLine("aaaaa");
            }
        }

        private static void Test2()
        {
            object[] values = {"a", "b", "c", "d", "e"};
            var collection = new IterationSample(values, 3);
            foreach (var obj in collection)
            {
                Console.WriteLine(obj);
            }
        }

        private static void Test1()
        {
            var startDate = new DateTime(2021, 6, 1);
            var endDate = new DateTime(2021, 6, 4);
            
            var timeTable = new TimeTable(startDate, endDate);
            
            for (var day = timeTable.startData; day <= endDate; day = day.AddDays(1))
            {
                Console.WriteLine(day);
            }
            
            Console.WriteLine();
            
            foreach (var day in timeTable)
            {
                Console.WriteLine(day);
            }
        }
    }
}