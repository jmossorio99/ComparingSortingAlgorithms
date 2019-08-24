using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace comparingAlgorithmsCSharp
{
    class Program
    {

        private readonly String filePath1 = @"set100.txt";
        private readonly String filePath2 = @"set1000.txt";
        private readonly String filePath3 = @"set10000.txt";
        private String[] filePaths = new string[] {@".. \.. \set100.txt", @".. \.. \set1000.txt", @".. \.. \set10000.txt" };
        private static readonly DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        private Heapsort heapsort;
        private Timsort timsort;
        private int countAux = 0;

        public Program()
        {

            List<List<int>> lists = readFiles();
            
            timsort = new Timsort();          

            long startTime = CurrentTimeMillis();
            List<int> resultPath1 = timsort.Sort(lists[0]);
            long totalTimePath1 = CurrentTimeMillis() - startTime;

            startTime = CurrentTimeMillis();
            List<int> resultPath2 = timsort.Sort(lists[1]);
            long totalTimePath2 = CurrentTimeMillis() - startTime;

            startTime = CurrentTimeMillis();
            List<int> resultPath3 = timsort.Sort(lists[2]);
            long totalTimePath3 = CurrentTimeMillis() - startTime;

            Console.WriteLine("time with 100 elements = " + totalTimePath1);
            Console.WriteLine("time with 1000 elements"+totalTimePath2);
            Console.WriteLine("time with 10000 elements"+totalTimePath3);
        }

        static void Main(string[] args)
        {

            Program program = new Program();

        }

        public static long CurrentTimeMillis()
        {
            return (long)(DateTime.UtcNow - dateTime).TotalMilliseconds;
        }

        public List<List<int>> readFiles()
        {
            List<List<int>> answer= new List<List<int>>();

            List<String> file1 = File.ReadAllLines(filePath1).ToList();
            List<String> file2 = File.ReadAllLines(filePath2).ToList();
            List<String> file3 = File.ReadAllLines(filePath3).ToList();

            answer.Add(ListToArray(file1));
            answer.Add(ListToArray(file2));
            answer.Add(ListToArray(file3));

            return answer;
        }

        public List<int> ListToArray(List<String> list)
        {

            List<int> convertedList = new List<int>();

            
            foreach (var line in list)
            {

                convertedList[countAux] = Convert.ToInt32(line);
                countAux++;
  
            }


            countAux = 0;
            return convertedList;
        }
    }
}
