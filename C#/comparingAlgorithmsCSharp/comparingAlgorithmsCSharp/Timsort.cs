using System;
using System.Collections.Generic;
using System.Text;

namespace comparingAlgorithmsCSharp
{ 
    class Timsort
    {
        private int maxPosition;
        private Boolean firstIteration;
        

        public Timsort()
        {
            maxPosition = -1;
            firstIteration = true;
        }

        public List<int> Sort(List<int> array)
        {

            List<int> sortedArray = new List<int>();

            foreach(int num in array)
            {              

                Insert(num,sortedArray,0,maxPosition);
                 
            }
            maxPosition = -1;
            firstIteration = false;
            return sortedArray;
        }

        private void Insert(int number,List<int> sortedArray,int inf,int sup)
        {
            if (sup == -1)
            {
                sortedArray.Add(number);
                maxPosition++;
                firstIteration = false;
            }

            else
            {
                int mid = (inf + sup) / 2;

                //situation 1 - number is smaller than the middle
                if (number < sortedArray[mid])
                {
                    // there is no one more left side
                    if (mid == 0)
                    {
                        sortedArray.Insert(0, number);
                        
                        maxPosition++;
                    }

                    //there are more elements left side
                    else
                    {

                        // left one is smaller than number
                        if (sortedArray[mid - 1] < number)
                        {
                            sortedArray.Insert(mid, number);
                            maxPosition++;
                        }
                        // need to split
                        else
                        {
                            Insert(number, sortedArray, inf, mid);
                        }

                    }

                }
                // situation 2 - number is bigger or same as middle
                else
                {

                    // no more elements on right
                    if (mid == maxPosition)
                    {
                        sortedArray.Add(number);
                        maxPosition++;
                    }

                    //there are more elements right side
                    else
                    {
                        // number is smaller that next on right
                        if (number < sortedArray[mid + 1])
                        {
                            sortedArray.Insert(mid + 1, number);
                            maxPosition++;
                        }

                        // need to split
                        else
                        {
                            Insert(number, sortedArray, mid, sup);
                        }
                    }

                }

            }
        }

        
    }
}
