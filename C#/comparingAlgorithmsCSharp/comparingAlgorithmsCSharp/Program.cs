using System;
using System.Diagnostics;

namespace comparingAlgorithmsCSharp
{
    class Program
    {

        public Program()
        {

            var sw = Stopwatch.StartNew();


            var elapsed = sw.ElapsedMilliseconds;

            Console.WriteLine(""+elapsed);
        }

        static void Main(string[] args)
        {

            Program program = new Program();

        }
    }
}
