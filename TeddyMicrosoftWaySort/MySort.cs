using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeddyMicrosoftWaySort
{
    public class MySort
    {
        /// <summary>
        /// Insert Sort Main method (ascending order)
        /// </summary>
        public static void InsertSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)//从第二个元素开始
            {
                int temp = arr[i];
                int j = i - 1;
                while (arr[j] > temp)//从从当前元素往右边找插入点
                {
                    arr[j + 1] = arr[j];//后移
                    j--;
                    if (j == -1)
                        break;
                }
                arr[j + 1] = temp;//前面已经后移了，会留下一个空位置，现在就插入
            }
        }
        /// <summary>
        /// OutPut method for Array
        /// </summary>
        public static void OutPut(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}\t", arr[i]);
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Testing each method
        /// </summary>
        public static void Main()
        {
            // Example Array
            int[] arr1 = GetRandom(1, 800, 50);
            int[] arr2 = GetRandom(2, 1000, 30);
            int[] arr3 = GetRandom(-1, 4000, 100);
            int[] arr4 = GetRandom(0, 60000, 150);
            int[] arr5 = GetRandom(0, 100000, 200);
            int[] arr6 = GetRandom(12, 123220, 300);

            /*  This is for InsertSort Testing  */
            Console.WriteLine("Insert sort testing");
            OutPut(arr1);
            InsertSort(arr1);
            Console.WriteLine("Insert sort OK");
            OutPut(arr1);

            /* This is for BubbleUpSort Testing */
            Console.WriteLine("BubbleUp sort testing");
            OutPut(arr2);
            Console.WriteLine("BubbleUp sort OK");
            OutPut(BubbleUpSort(arr2));

            /* This is for QuickSort Testing */
            Console.WriteLine("Quick sort testing");
            OutPut(arr3);
            Console.WriteLine("Quick sort OK");
            QuickSort(arr3, 0, arr3.Length - 1);
            OutPut(arr3);

            /* This is for MergeSort Testing */
            Console.WriteLine("Merge sort testing");
            OutPut(arr5);
            Console.WriteLine("Merge sort OK");
            MergeSort(arr5);

            /* This is for MergeSort Testing */
            Console.WriteLine("Heap sort testing");
            OutPut(arr6);
            Console.WriteLine("Heap sort OK");
            HeapSort(arr6);

            /* This is Common method */
            Console.ReadLine();
        }
        /// <summary>
        /// BubbleUp Sort Main method (ascending order)
        /// </summary>
        public static int[] BubbleUpSort(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] > Array[j])
                    {
                        int temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = temp;
                    }
                }
            }
            return Array;
        }
        /// <summary>
        /// Quick Sort Main method (ascending order)  
        /// </summary>
        public static void QuickSort(int[] a, int left, int right)
        {
            if (left < right)
            {
                int i = Partition(a, left, right);
                QuickSort(a, left, i - 1);
                QuickSort(a, i + 1, right);
            }
        }
        /// <summary>
        /// Support method for Quick Sort
        /// </summary>
        private static int Partition(int[] a, int left, int right)
        {
            int tmp = a[left];
            while (left < right)
            {
                while (left < right && a[right] >= tmp)
                    right--;

                // 换位后不能将left+1,防止跳位
                if (left < right)
                    a[left] = a[right];
                while (left < right && a[left] <= tmp)
                    left++;
                if (left < right)
                {
                    a[right] = a[left];
                    // 有left < right，可将right向前推一位
                    right--;
                }
            }
            a[left] = tmp;
            return left;
        }
        /// <summary>
        /// Merge Sort Main method (ascending order)
        /// </summary>
        public static void MergeSort(int[] intArr)
        {
            int numberOfLoop = 0;
            int numberOfSwap = 0;
            int[] tempArr = new int[intArr.Length];
            MergeAdjust(tempArr, ref intArr, 0, intArr.Length - 1, ref numberOfLoop, ref numberOfSwap);
            DisplaySortResult(numberOfLoop, numberOfSwap, intArr);
        }
        /// <summary>
        /// Support method for Merge Sort
        /// </summary>
        private static void MergeAdjust(int[] tempArr, ref int[] intArr, int left, int right, ref int numberOfLoop, ref int numberOfSwap)
        {
            if (left != right)
            {
                int middle = (left + right) / 2;

                //递归，继续细分数组，最后比较相邻的两个元素  
                MergeAdjust(tempArr, ref intArr, left, middle, ref numberOfLoop, ref numberOfSwap);
                MergeAdjust(tempArr, ref intArr, middle + 1, right, ref numberOfLoop, ref numberOfSwap);

                //归并
                Merge(tempArr, ref intArr, left, middle + 1, right, ref numberOfLoop, ref numberOfSwap);
            }
        }
        /// <summary>
        /// Support method for Merge Sort
        /// </summary>
        private static void Merge(int[] tempArr, ref int[] intArr, int left, int rl, int right, ref int numberOfLoop, ref int numberOfSwap)
        {
            int ll = left;//数组一左侧  
            int lr = rl - 1;//数组一右侧  
            int i = 0;

            while (ll <= lr && rl <= right)
            {
                numberOfLoop++;
                numberOfSwap++;
                //两个数组比较，将小的先插入  
                if (intArr[ll] < intArr[rl])
                {
                    tempArr[i] = intArr[ll];
                    ll++;
                }
                else
                {
                    tempArr[i] = intArr[rl];
                    rl++;
                }
                i++;
            }
            //上边对数组进行归并后，可能有一个数组会有剩余的元素  
            //拷贝数组一剩余的部分到临时数组  
            while (ll <= lr)
            {
                numberOfLoop++;
                numberOfSwap++;
                tempArr[i] = intArr[ll];
                ll++;
                i++;
            }
            //拷贝数组二剩余的部分到临时数组  
            while (rl <= right)
            {
                numberOfLoop++;
                numberOfSwap++;
                tempArr[i] = intArr[rl];
                rl++;
                i++;
            }
            //将有序数据更新到数组中  
            for (int j = 0; j <= i - 1; j++)
            {
                numberOfSwap++;
                intArr[left + j] = tempArr[j];
            }
        }
        /// <summary>
        /// Support method for Merge Sort
        /// </summary>
        private static void DisplaySortResult(int numberOfLoop, int numberOfSwap, int[] intArr)
        {
            foreach (int i in intArr)
            {
                //Console.Write(i.ToString() + ",");
                Console.Write("{0}\t", i);
            }
            Console.WriteLine("");
            Console.WriteLine("Loop number: " + numberOfLoop.ToString());
            Console.WriteLine("Swap number: " + numberOfSwap.ToString());
        }
        /// <summary>
        /// Heap Sort Main method (ascending order)
        /// </summary>
        public static void HeapSort(int[] intArr)
        {
            int numberOfLoop = 0;
            int numberOfSwap = 0;
            //第一次创建大堆 　　
            for (int i = intArr.Length / 2 - 1; i >= 0; i--)
            {
                numberOfLoop++;
                HeapAdjust(intArr, i, intArr.Length, ref numberOfLoop, ref numberOfSwap);
            }
            //元素位置调换，无序区通过调整为有序区，获得最大的值 　　
            for (int i = intArr.Length - 1; i > 0; i--)
            {
                numberOfLoop++;
                numberOfSwap++;
                //堆顶（最大值）与当前堆的最后一个堆元素交换位置 　　
                int tmp = intArr[0];
                intArr[0] = intArr[i];
                intArr[i] = tmp;
                //将剩下的无序堆部分重新建堆处理，因为只是将最大值转移，因此只需要一轮排序，获取最大值　　
                HeapAdjust(intArr, 0, i, ref numberOfLoop, ref numberOfSwap);
            }
            DisplaySortResult(numberOfLoop, numberOfSwap, intArr);
        }
        /// <summary>
        /// Support method for Heap Sort
        /// </summary>
        private static void HeapAdjust(int[] intArr, int i, int length, ref int numberOfLoop, ref int numberOfSwap)
        {
            int temp = intArr[i];
            int child = 2 * i + 1;

            while (child < length)
            {
                //如果存在右节点，且大于左节点，child++
                if (child < length - 1 && intArr[child] < intArr[child + 1])
                {
                    numberOfLoop++;
                    child++;
                }
                //父节点大于左右子节点，跳出循环
                if (temp >= intArr[child]) break;
                numberOfSwap++;
                //否则设置父节点为最大的子节点值
                intArr[i] = intArr[child];
                i = child;
                child = 2 * i + 1;
            }
            numberOfSwap++;
            intArr[i] = temp;
        }
        /// <summary>
        /// Get Random Array
        /// </summary>
        private static int[] GetRandom(int minValue, int maxValue, int count)
        {
            Random rnd = new Random();
            int length = maxValue - minValue + 1;
            byte[] keys = new byte[length];
            rnd.NextBytes(keys);
            int[] items = new int[length];
            for (int i = 0; i < length; i++)
            {
                items[i] = i + minValue;
            }
            Array.Sort(keys, items);
            int[] result = new int[count];
            Array.Copy(items, result, count);
            return result;
        }
    }
}
