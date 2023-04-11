using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchAndSorting
{
    public class InsertionSort
    {
        public void DisplayInsertion()
        {
            string[] arr = new string[] { "Bhole", "Ram", "Shyam", "Durga" };
            Console.WriteLine("unsorted Array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            for (int i = 1; i < arr.Length; i++)
            {
                string value = arr[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[j].CompareTo(value) > 0)
                    {
                        string temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }


            Console.WriteLine(" Sorted Array");
            foreach (string item in arr)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
