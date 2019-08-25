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

            List<int[]> lists = readFiles();
            
            //Timsort-------------------------------------------------------------------------------------------

            timsort = new Timsort();          

            long startTime = CurrentTimeMillis();            
            List<int> resultPath1Timsort = timsort.Sort(lists[0]);           
            long totalTimePath1Timsort = CurrentTimeMillis() - startTime;

            startTime = CurrentTimeMillis();           
            List<int> resultPath2Timsort = timsort.Sort(lists[1]);        
            long totalTimePath2Timsort = CurrentTimeMillis() - startTime;

            startTime = CurrentTimeMillis();
            List<int> resultPath3Timsort = timsort.Sort(lists[2]);
            long totalTimePath3Timsort = CurrentTimeMillis() - startTime;

            Console.WriteLine("time with 100 elements Timsort = " + totalTimePath1Timsort);
            Console.WriteLine("time with 1000 elements Timsort = " + totalTimePath2Timsort);
            Console.WriteLine("time with 10000 elements Timsort = " + totalTimePath3Timsort);

            // Heapsort-------------------------------------------------------------------------------------------

            //100

            heapsort = new Heapsort(100);

            startTime = CurrentTimeMillis();
            List<int> resultPath1HeapSort = heapsort.Sort(lists[0]);
            long totalTimePath1Heapsort = CurrentTimeMillis() - startTime;

            //1000

            heapsort = new Heapsort(1000);

            startTime = CurrentTimeMillis();
            List<int> resultPath2Heapsort = heapsort.Sort(lists[1]);
            long totalTimePath2Heapsort = CurrentTimeMillis() - startTime;

            //10000

            heapsort = new Heapsort(10000);

            startTime = CurrentTimeMillis();
            List<int> resultPath3Heapsort = heapsort.Sort(lists[2]);
            long totalTimePath3Heapsort = CurrentTimeMillis() - startTime;

            Console.WriteLine("");
            Console.WriteLine("time with 100 elements Heapsort = " + totalTimePath1Heapsort);
            Console.WriteLine("time with 1000 elements Heapsort = " + totalTimePath2Heapsort);
            Console.WriteLine("time with 10000 elements Heapsort = " + totalTimePath3Heapsort);
        }

        static void Main(string[] args)
        {

            Program program = new Program();

        }

        public static long CurrentTimeMillis()
        {
            return (long)(DateTime.UtcNow - dateTime).TotalMilliseconds;
        }

        public List<int[]> readFiles()
        {
            List<int[]> answer= new List<int[]>();

            List<String> file1 = File.ReadAllLines(filePath1).ToList();
            List<String> file2 = File.ReadAllLines(filePath2).ToList();
            List<String> file3 = File.ReadAllLines(filePath3).ToList();

           
            answer.Add(ListToArray(file1));
            
            answer.Add(ListToArray(file2));
            
            answer.Add(ListToArray(file3));

            return answer;
        }

        public int[] ListToArray(List<String> list)
        {
            
           int[] convertedList = new int[list.Count];

            
            foreach (var line in list)
            {
                int temp = Int32.Parse(line);

                
                convertedList[countAux] = temp;
                countAux++;

            }


            countAux = 0;
            return convertedList;
        }
    }
}
