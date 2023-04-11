using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchAndSorting
{
    public class MergeSorting
    {
        public static List<string> Sort(List<string> list)
        {
            if (list == null || list.Count <= 1)
            {
                return list;
            }

            int mid = list.Count / 2;
            List<string> left = new List<string>();
            List<string> right = new List<string>();

            for (int i = 0; i < mid; i++)
            {
                left.Add(list[i]);
            }
            left = Sort(left);

            for (int i = mid; i < list.Count; i++)
            {
                right.Add(list[i]);
            }
            right = Sort(right);

            return MergeSort(left, right);
        }

        public static List<string> MergeSort(List<string> left, List<string> right)
        {
            List<string> result = new List<string>();
            int leftIndex = 0;
            int rightIndex = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (left[leftIndex].CompareTo(right[rightIndex]) < 0)
                {
                    result.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    result.Add(right[rightIndex]);
                    rightIndex++;
                }

            }
            while (leftIndex < left.Count)
            {
                result.Add(left[leftIndex]);
                leftIndex++;
            }

            while (rightIndex < right.Count)
            {
                result.Add(right[rightIndex]);
                rightIndex++;
            }

            return result;


        }
    }
}
