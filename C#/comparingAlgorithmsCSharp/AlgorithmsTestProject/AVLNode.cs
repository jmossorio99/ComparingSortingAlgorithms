using System;
using System.Collections.Generic;
using System.Text;

namespace comparingAlgorithmsCSharp
{
    class AVLNode
    {
        private int data;
        private AVLNode left;
        private AVLNode right;
        public int level;
        private int height;

        public AVLNode(int data,AVLNode left,AVLNode right)
        {
            this.data=data;
            this.left = left;
            this.right = right;
            height = 1;
        }

        public AVLNode(int data)
        {
            this.data = data;
            left = null;
            right = null;
        }

        public int getData()
        {
            return data; 
        }

        public void setData(int data)
        {
            this.data = data;
        }

        public AVLNode getLeft()
        {
            return left;
        }

        public void setLeft(AVLNode left)
        {
            this.left = left;
        }

        public AVLNode getRight()
        {
            return right;
        }

        public void setRight(AVLNode right)
        {
            this.right = right;
        }

        public void setHeight(int depth)
        {
            this.height = depth;
        }

        public int getHeight()
        {
            return height;
        }

        public int compareTo(AVLNode o)
        {
            return this.data.CompareTo(o.getData());
        }
    }
}
