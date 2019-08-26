using System;
using System.Collections.Generic;
using System.Text;

namespace comparingAlgorithmsCSharp
{
    class AVLTree
    {

        private AVLNode root;

        public AVLTree()
        {
            root = null;
        }

        public AVLTree(AVLNode root)
        {
            this.root = root;
        }

        public AVLNode getRoot()
        {

            return root;

        }



        public int getMax()
        {



            AVLNode current = root;

            if (current == null)
            {

                return Int32.MaxValue;

            }

            while (current.getRight() != null)
            {

                current = current.getRight();

            }

            return current.getData();



        }



        public int getMin()
        {



            AVLNode current = root;

            if (current == null)
            {

                return Int32.MinValue;

            }

            while (current.getLeft() != null)
            {

                current = current.getLeft();

            }

            return current.getData();



        }



        public void insert(int data)
        {



            root = insert(root, data);



        }



        private AVLNode insert(AVLNode node, int value)
        {



            if (node == null)
            {

                return new AVLNode(value, null, null);

            }
            else
            {

                if (node.compareTo(new AVLNode(value, null, null)) > 0)
                {

                    node.setLeft(insert(node.getLeft(), value));

                }
                else
                {

                    node.setRight(insert(node.getRight(), value));

                }

                node.setHeight(Math.Max(height(node.getLeft()), height(node.getRight())) + 1);
                
                int balanceFactor = BalanceFactor(node);

                if (balanceFactor < -1)
                {

                    if (BalanceFactor(node.getRight()) > 0)
                    {

                        node.setRight(rotateRight(node.getRight()));

                        return rotateLeft(node);

                    }
                    else
                    {

                        return rotateLeft(node);

                    }

                }
                else if (balanceFactor > 1)
                {

                    if (BalanceFactor(node.getLeft()) < 0)
                    {

                        node.setLeft(rotateLeft(node.getLeft()));

                        return rotateRight(node);

                    }
                    else
                    {

                        return rotateRight(node);

                    }

                }

            }

            return node;



        }



        public void delete(AVLNode root, int value)
        {



            root = deleteR(root, value);



        }



        public AVLNode deleteR(AVLNode root, int value)
        {



            if (root == null)
            {

                return root;

            }

            AVLNode toCompare = new AVLNode(value, null, null);

            if (toCompare.compareTo(root) < 0)
            {

                root.setLeft(deleteR(root.getLeft(), value));

            }
            else if (toCompare.compareTo(root) > 0)
            {

                root.setRight(deleteR(root.getRight(), value));

            }
            else
            {



                if (root.getLeft() == null || root.getRight() == null)
                {



                    AVLNode temp = null;

                    if (temp == root.getLeft())
                    {

                        temp = root.getRight();

                    }
                    else
                    {

                        temp = root.getLeft();

                    }



                    if (temp == null)
                    {

                        temp = root;

                        root = null;

                    }
                    else
                    {

                        root = temp;

                    }



                }
                else
                {

                    AVLNode temp = minValueNode(root.getRight());

                    root.setData(temp.getData());
                   
                    root.setRight(deleteR(root.getRight(), temp.getData()));

                }



            }



            if (root == null)
            {

                return root;

            }

            root.setHeight(Math.Max(height(root.getLeft()), height(root.getRight())) + 1);

            int balanceFactor = BalanceFactor(root);

            if (balanceFactor < -1)
            {

                if (BalanceFactor(root.getRight()) > 0)
                {

                    root.setRight(rotateRight(root.getRight()));

                    return rotateLeft(root);

                }
                else
                {

                    return rotateLeft(root);

                }

            }
            else if (balanceFactor > 1)
            {

                if (BalanceFactor(root.getLeft())< 0)
                {

                    root.setLeft(rotateLeft(root.getLeft()));

                    return rotateRight(root);

                }
                else
                {

                    return rotateRight(root);

                }

            }

            return root;



        }


        public int BalanceFactor(AVLNode node)
        {

            if (node == null)
            {

                return 0;

            }

            return height(node.getLeft()) - height(node.getRight());

        }



        private AVLNode rotateLeft(AVLNode node)
        {



            AVLNode r = node.getRight();

            node.setRight(r.getLeft());

            r.setLeft(node);

            node.setHeight(Math.Max(height(node.getLeft()), height(node.getRight())) + 1);

            r.setHeight(Math.Max(height(r.getLeft()), height(r.getRight())) + 1);

            return r;



        }



        private AVLNode rotateRight(AVLNode node)
        {



            AVLNode l = node.getLeft();

            node.setLeft(l.getRight());

            l.setRight(node);

            node.setHeight(Math.Max(height(node.getLeft()), height(node.getRight())) + 1);

            l.setHeight(Math.Max(height(l.getLeft()), height(l.getRight())) + 1);

            return l;



        }



        private int height(AVLNode node)
        {

            if (node == null)
            {

                return 0;

            }

            return node.getHeight();

        }



        private AVLNode minValueNode(AVLNode node)
        {



            AVLNode current = node;

            while (current.getLeft() != null)
            {

                current = current.getLeft();

            }

            return current;



        }



        public void inOrder(AVLNode node, List<int> result)
        {

            if (node != null)
            {

                inOrder(node.getLeft(), result);

                result.Add(node.getData());
               
                inOrder(node.getRight(), result);

            }

        }



        public void inOrderDesc(AVLNode node, List<int> result)
        {

            if (node != null)
            {

                inOrderDesc(node.getRight(), result);

                result.Add(node.getData());

                inOrderDesc(node.getLeft(), result);

            }

        }
    }
}
