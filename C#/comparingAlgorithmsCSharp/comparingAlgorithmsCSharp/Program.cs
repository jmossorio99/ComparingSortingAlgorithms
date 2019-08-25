using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace comparingAlgorithmsCSharp
{
    class Program
    {

        private readonly String FILE_PATH1 = @"set10000.txt";
        private readonly String FILE_PATH2 = @"set100000.txt";
        private readonly String fFILE_PATH3 = @"set1000000.txt";
        private static readonly DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        private Heapsort heapsort;
        private Treesort treesort;
        private int countAux = 0;

        public Program()
        {

            List<int[]> lists = readFiles();
            
            //Treesort-------------------------------------------------------------------------------------------

            treesort = new Treesort();

            long startTime = CurrentTimeMillis();            
            List<int> resultPath1Timsort = treesort.Sort(lists[0]);           
            long totalTimePath1Timsort = CurrentTimeMillis() - startTime;

            treesort = new Treesort();

            startTime = CurrentTimeMillis();           
            List<int> resultPath2Timsort = treesort.Sort(lists[1]);        
            long totalTimePath2Timsort = CurrentTimeMillis() - startTime;

            treesort = new Treesort();

            startTime = CurrentTimeMillis();
            List<int> resultPath3Timsort = treesort.Sort(lists[2]);
            long totalTimePath3Timsort = CurrentTimeMillis() - startTime;

            
            Console.WriteLine("time with 10000 elements Treesort = " + totalTimePath1Timsort/1000.0 + "s");
            Console.WriteLine("time with 100000 elements Treesort = " + totalTimePath2Timsort/1000.0 + "s");
            Console.WriteLine("time with 1000000 elements Treesort = " + totalTimePath3Timsort/1000.0 + "s");

            // Heapsort-------------------------------------------------------------------------------------------

            //100

            heapsort = new Heapsort(10000);

            startTime = CurrentTimeMillis();
            List<int> resultPath1Heapsort = heapsort.Sort(lists[0]);
            long totalTimePath1Heapsort = CurrentTimeMillis() - startTime;

            //1000

            heapsort = new Heapsort(100000);

            startTime = CurrentTimeMillis();
            List<int> resultPath2Heapsort = heapsort.Sort(lists[1]);
            long totalTimePath2Heapsort = CurrentTimeMillis() - startTime;

            //10000

            heapsort = new Heapsort(1000000);

            startTime = CurrentTimeMillis();
            List<int> resultPath3Heapsort = heapsort.Sort(lists[2]);
            long totalTimePath3Heapsort = CurrentTimeMillis() - startTime;

            Console.WriteLine("");
            Console.WriteLine("time with 10000 elements Heapsort = " + totalTimePath1Heapsort/1000.0+"s");
            Console.WriteLine("time with 100000 elements Heapsort = " + totalTimePath2Heapsort/1000.0 + "s");
            Console.WriteLine("time with 1000000 elements Heapsort = " + totalTimePath3Heapsort/1000.0 + "s");

           // ListIntToString(resultPath3Heapsort);
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

            List<String> file1 = File.ReadAllLines(FILE_PATH1).ToList();
            List<String> file2 = File.ReadAllLines(FILE_PATH2).ToList();
            List<String> file3 = File.ReadAllLines(fFILE_PATH3).ToList();

           
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

        public void ListIntToString(List<int> list           )
        {

            foreach (int i in list)
            {
                Console.WriteLine(""+i);
            }

        }
    }
}
