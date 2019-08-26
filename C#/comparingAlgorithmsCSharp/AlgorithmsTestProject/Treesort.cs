using System;
using System.Collections.Generic;
using System.Text;

namespace comparingAlgorithmsCSharp
{
    class Treesort
    {

        private AVLTree avl = new AVLTree();

        public List<int> Sort(int[] array)
        {
            List<int> result = new List<int>();

            foreach (int i in array)
            {
                avl.insert(i);
            }

            avl.inOrder(avl.getRoot(),result);

            return result;
        }

    }
}
