using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сортировки_пузырьком_и_выборкой
{
    public enum MethodsSort
    {
        Random,
        Increase,
        Decrease
    }
    public enum Algorithms
    {
        Bubble,
        Choice,
        Quick,
        Merge
    }
    class SomeSorts
    {
        private int sizeArray { get; set; }
        private Tuple<int, int> rangeNumbers { get; set; }
        private int startSequence { get; set; }
        private MethodsSort currentMethod { get; set; }
        public int[] inputArray { get; set; }
        public int[] outputArray { get; set; }

        /**
         * Default settings: 
         * range = (-100, 100),
         * startSeq = 0.
         */

        /**
         * Init constructors(Инициализация конструкторов)
         */
        public SomeSorts(int sizeArray, MethodsSequience sMethod)
        {
            this.sizeArray = sizeArray;
            currentMethod = sMethod.methodsSort;
            rangeNumbers = Tuple.Create(sMethod.startRange, sMethod.endRange);
            startSequence = sMethod.startPosition;
            GenerateArray();
        }

        void GenerateArray()
        {
            inputArray = new int[sizeArray];

            if (currentMethod == MethodsSort.Random)
            {
                Random r = new Random(Environment.TickCount);
                inputArray = inputArray.Select(x => x = r.Next(rangeNumbers.Item1, rangeNumbers.Item2)).ToArray();
            }
            else if (currentMethod == MethodsSort.Increase)
            {
                int tempIncreaser = startSequence;
                inputArray = inputArray.Select(x => x = tempIncreaser++).ToArray();
            }
            else if (currentMethod == MethodsSort.Decrease)
            {
                int tempDecreaser = startSequence;
                inputArray = inputArray.Select(x => x = tempDecreaser--).ToArray();
            }
        }
        /************************************************ SORT ALGORITHMS ************************************************/
        /**
         * Sort Bubble(Пузырьковая сортировка) O(n^2)
         */
        public Tuple<int, double, decimal[]> SortBubble()
        {
            outputArray = new int[inputArray.Length];
            Array.Copy(inputArray, outputArray, inputArray.Length);
            //Statistics
            Stopwatch sw = new Stopwatch();
            decimal[] sCounter = { 0, 0 };
            sw.Start();
            for (int i = 0; i < outputArray.Length; i++)
            {
                for (int j = i + 1; j < outputArray.Length; j++)
                {
                    ++sCounter[1];
                    if (outputArray[i] > outputArray[j])
                    {
                        int tempVar = outputArray[i];
                        outputArray[i] = outputArray[j];
                        outputArray[j] = tempVar;
                        ++sCounter[0];
                    }
                }
            }
            sw.Stop();

            return Tuple.Create(sizeArray, (double)sw.ElapsedMilliseconds, sCounter);
        }
        /**
         * Sort Choice(Сортировка выбором) O(n^2)
         */
        public Tuple<int, double, decimal[]> SortChoice()
        {
            outputArray = new int[inputArray.Length];
            Array.Copy(inputArray, outputArray, inputArray.Length);
            //Statistics
            Stopwatch sw = new Stopwatch();
            decimal[] sCounter = { 0, 0 };
            sw.Start();
            for (int i = 0; i < outputArray.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < outputArray.Length; j++)
                {
                    if (outputArray[j] < outputArray[min]) min = j;
                        ++sCounter[1];
                }
                int tempVar = outputArray[min];
                outputArray[min] = outputArray[i];
                outputArray[i] = tempVar;
                ++sCounter[0];
            }
            sw.Stop();

            return Tuple.Create(sizeArray, (double)sw.ElapsedMilliseconds, sCounter);
        }

        /**
         * MergeSort(Сортировка выбором) O(n log(n))
         */
        public Tuple<int, double, decimal[]> MergeSort()
        {
            outputArray = new int[inputArray.Length];
            Array.Copy(inputArray, outputArray, inputArray.Length);
            //Statistics
            Stopwatch sw = new Stopwatch();
            decimal[] sCounter = { 0, 0 };

            sw.Start();
            InternalMergeDivider(outputArray, sCounter);
            sw.Stop();

            return Tuple.Create(sizeArray, (double)sw.ElapsedMilliseconds, sCounter);
        }

        int[] InternalMergeDivider(int[] arr, decimal[] sCounter)
        {
            if (arr.Length > 1)
            {
                int[] leftArr = Enumerable.Range(0, arr.Length / 2).Select(x => arr[x]).ToArray();
                int[] rightArr = Enumerable.Range(leftArr.Length, arr.Length - leftArr.Length).Select(x => arr[x]).ToArray();

                if (leftArr.Length > 1)
                    leftArr = InternalMergeDivider(leftArr, sCounter);
                if (rightArr.Length > 1)
                    rightArr = InternalMergeDivider(rightArr, sCounter);

                arr = InternalMergeSort(leftArr, rightArr, sCounter);
            }

            return arr;
        }

        int[] InternalMergeSort(int[] left, int[] right, decimal[] sCounter)
        {
            int[] buff = new int[left.Length + right.Length];
            int lSide = 0;
            int rSide = 0;
            for (int i = 0; i < buff.Length; i++)
            {
                sCounter[0]++;
                if (rSide >= right.Length || (lSide < left.Length && left[lSide] < right[rSide]))
                {
                    buff[i] = left[lSide];
                    lSide++;
                }
                else
                {
                    buff[i] = right[rSide];
                    rSide++;
                    sCounter[1]++;
                }
            }
            return buff;
        }
        /**
         * QuickSort: O(n^2) | O(n * log(n))
         */
        public Tuple<int, double, decimal[]> QuickSort()
        {
            outputArray = new int[inputArray.Length];
            Array.Copy(inputArray, outputArray, inputArray.Length);
            //Statistics
            decimal[] sCounter = { 0, 0 };
            Stopwatch sw = new Stopwatch();

            //Middle Element
            sw.Start();
            InternalQuickSort(0, outputArray.Length - 1, sCounter);
            sw.Stop();

            return Tuple.Create(sizeArray, (double)sw.ElapsedMilliseconds, sCounter);
        }

        public void InternalQuickSort(long firstIndex, long lastIndex, decimal[] sCounter)
        {
            int supMember = outputArray[(lastIndex - firstIndex) / 2 + firstIndex];
            int temp = 0;
            long i = firstIndex, j = lastIndex;
            while (i <= j)
            {
                while (outputArray[i] < supMember && i <= lastIndex) ++i;
                while (outputArray[j] > supMember && j >= firstIndex) --j;
                if (i <= j)
                {
                    temp = outputArray[i];
                    outputArray[i] = outputArray[j];
                    outputArray[j] = temp;
                    ++i; --j; sCounter[1]++;
                }
                sCounter[0]++;
            }

            if (j > firstIndex) InternalQuickSort(firstIndex, j, sCounter);
            if (i < lastIndex) InternalQuickSort(i, lastIndex, sCounter);
        }
    }
}
