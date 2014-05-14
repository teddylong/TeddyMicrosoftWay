using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeddyMicrosoftWaySearch
{
    public class MySearch
    {
        /// <summary>
        /// Testing each search method
        /// </summary>
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            int sequenceResult = SequenceSearch(arr, 40);
            Console.WriteLine(sequenceResult);

            int BinaryResult = BinarySearch(arr, 80);
            Console.WriteLine(BinaryResult);

            Console.ReadLine();
        }
        /// <summary>
        /// Sequence Search method
        /// </summary>
        public static int SequenceSearch(int[] arr, int key)
        {
            int i = -1;
            if (arr.Length <= 1) 
            {
                if (arr[0] == key)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            if(arr[0] == key)
            {
                return 0;
            }
            arr[0] = key;
            bool flag = false;
            for (i = 1; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                i = -404;
            }
            return i;
        }
        /// <summary>
        /// Binary Search method  (要求查找表本身是有序的)
        /// </summary>
        public static int BinarySearch(int[] arr, int key)
        {
            if (arr[0] == key)
            {
                return 0;
            }
            arr[0] = key;
            int mid = 0;
            int flag = -1;
            int low = 1;
            int high = arr.Length - 1;

            while (low <= high)
            {
                mid = (low + high) / 2;
                if (key == arr[mid])
                {
                    flag = mid;
                    break;
                }
                else if (key < arr[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            if (flag > 0)
            {
                return flag;
            }
            else
            {
                return -1;
            }
        }
        
    }
}
