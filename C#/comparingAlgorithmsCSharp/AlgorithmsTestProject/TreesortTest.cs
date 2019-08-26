using System;
using System.Collections.Generic;
using comparingAlgorithmsCSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTestProject
{
    [TestClass]
    public class TreesortTest
    {

        private Treesort treesort;
        private int[] expectedResult;
        private int[] list;

        [TestMethod]
        public void TestSort1A()
        {

            setScene1A();

            List<int> result = new List<int>();

            result = treesort.Sort(list);

            Boolean same = true;

            for (int i=0;i<result.Count && same;i++)
            {

                if (expectedResult[i]!=result[i])
                {
                    same = false;
                }

            }
            Assert.IsTrue(same);
        }

        [TestMethod]
        public void TestSort1B()
        {
            setScene1B();

            List<int> result = new List<int>();

            result = treesort.Sort(list);

            Boolean same = true;

            for (int i = 0; i < result.Count && same; i++)
            {

                if (expectedResult[i] != result[i])
                {
                    same = false;
                }

            }
            Assert.IsTrue(same);
        }

        [TestMethod]
        public void TestSort1C()
        {
            setScene1C();

            List<int> result = new List<int>();

            result = treesort.Sort(list);

            Boolean same = true;

            for (int i = 0; i < result.Count && same; i++)
            {

                if (expectedResult[i] != result[i])
                {
                    same = false;
                }

            }
            Assert.IsTrue(same);
        }

        [TestMethod]
        public void TestSort2A()
        {
            setScene2A();

            List<int> result = new List<int>();

            result = treesort.Sort(list);

            Boolean same = true;

            for (int i = 0; i < result.Count && same; i++)
            {

                if (expectedResult[i] != result[i])
                {
                    same = false;
                }

            }
            Assert.IsTrue(same);
        }

        [TestMethod]
        public void TestSort2B()
        {
            setScene2B();

            List<int> result = new List<int>();

            result = treesort.Sort(list);

            Boolean same = true;

            for (int i = 0; i < result.Count && same; i++)
            {

                if (expectedResult[i] != result[i])
                {
                    same = false;
                }

            }
            Assert.IsTrue(same);
        }

        [TestMethod]
        public void TestSort2C()
        {
            setScene2C();

            List<int> result = new List<int>();

            result = treesort.Sort(list);

            Boolean same = true;

            for (int i = 0; i < result.Count && same; i++)
            {

                if (expectedResult[i] != result[i])
                {
                    same = false;
                }

            }
            Assert.IsTrue(same);
        }

        public void setScene1A()
        {
            treesort = new Treesort();
            list = new int[10];
            expectedResult = new int[10];

            list[0] = 1;
            list[1] = 2;
            list[2] = 3;
            list[3] = 4;
            list[4] = 5;
            list[5] = 6;
            list[6] = 7;
            list[7] = 8;
            list[8] = 9;
            list[9] = 10;

            expectedResult[0] = 1;
            expectedResult[1] = 2;
            expectedResult[2] = 3;
            expectedResult[3] = 4;
            expectedResult[4] = 5;
            expectedResult[5] = 6;
            expectedResult[6] = 7;
            expectedResult[7] = 8;
            expectedResult[8] = 9;
            expectedResult[9] = 10;

        }

        public void setScene1B()
        {
            treesort = new Treesort();
            list = new int[10];
            expectedResult = new int[10];

            list[0] = 10;
            list[1] = 9;
            list[2] = 8;
            list[3] = 7;
            list[4] = 6;
            list[5] = 5;
            list[6] = 4;
            list[7] = 3;
            list[8] = 2;
            list[9] = 1;

            expectedResult[0] = 1;
            expectedResult[1] = 2;
            expectedResult[2] = 3;
            expectedResult[3] = 4;
            expectedResult[4] = 5;
            expectedResult[5] = 6;
            expectedResult[6] = 7;
            expectedResult[7] = 8;
            expectedResult[8] = 9;
            expectedResult[9] = 10;
        }

        public void setScene1C()
        {
            treesort = new Treesort();
            list = new int[10];
            expectedResult = new int[10];

            list[0] = 2;
            list[1] = 9;
            list[2] = 1;
            list[3] = 6;
            list[4] = 3;
            list[5] = 7;
            list[6] = 4;
            list[7] = 5;
            list[8] = 8;
            list[9] = 10;

            expectedResult[0] = 1;
            expectedResult[1] = 2;
            expectedResult[2] = 3;
            expectedResult[3] = 4;
            expectedResult[4] = 5;
            expectedResult[5] = 6;
            expectedResult[6] = 7;
            expectedResult[7] = 8;
            expectedResult[8] = 9;
            expectedResult[9] = 10;
        }

        public void setScene2A()
        {
            treesort = new Treesort();
            list = new int[9];
            expectedResult = new int[9];

            list[0] = 1;
            list[1] = 2;
            list[2] = 3;
            list[3] = 4;
            list[4] = 5;
            list[5] = 6;
            list[6] = 7;
            list[7] = 8;
            list[8] = 9;


            expectedResult[0] = 1;
            expectedResult[1] = 2;
            expectedResult[2] = 3;
            expectedResult[3] = 4;
            expectedResult[4] = 5;
            expectedResult[5] = 6;
            expectedResult[6] = 7;
            expectedResult[7] = 8;
            expectedResult[8] = 9;

        }

        public void setScene2B()
        {
            treesort = new Treesort();
            list = new int[9];
            expectedResult = new int[9];

            list[0] = 9;
            list[1] = 8;
            list[2] = 7;
            list[3] = 6;
            list[4] = 5;
            list[5] = 4;
            list[6] = 3;
            list[7] = 2;
            list[8] = 1;


            expectedResult[0] = 1;
            expectedResult[1] = 2;
            expectedResult[2] = 3;
            expectedResult[3] = 4;
            expectedResult[4] = 5;
            expectedResult[5] = 6;
            expectedResult[6] = 7;
            expectedResult[7] = 8;
            expectedResult[8] = 9;

        }

        public void setScene2C()
        {
            treesort = new Treesort();
            list = new int[9];
            expectedResult = new int[9];

            list[0] = 2;
            list[1] = 9;
            list[2] = 1;
            list[3] = 6;
            list[4] = 3;
            list[5] = 7;
            list[6] = 4;
            list[7] = 5;
            list[8] = 8;


            expectedResult[0] = 1;
            expectedResult[1] = 2;
            expectedResult[2] = 3;
            expectedResult[3] = 4;
            expectedResult[4] = 5;
            expectedResult[5] = 6;
            expectedResult[6] = 7;
            expectedResult[7] = 8;
            expectedResult[8] = 9;

        }
    }
}
