using System;
using System.Collections.Generic;
using System.Text;

namespace comparingAlgorithmsCSharp
{
   
        class Heapsort
    {

        private MinHeap heap;


        public Heapsort(int maxSize)
        {

            heap = new MinHeap(maxSize);

        }

        public List<int> Sort(int[] list)
        {

            List<int> sortList = new List<int>();

            foreach (int i in list)
            {

                heap.Add(i);

            }

            while (heap.IsEmpty()==false)
            {

                sortList.Add(heap.Pop());

            }

            return sortList;
        }
    }
}
