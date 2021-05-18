using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
	// Recursive C# program to reverse
	// a linked list
	using System;
    using System.IO;

    public class MergerAndQuickSort
	{
        void Sort(int[] arr, int l, int r)
        {
            if(l<r)
            {
                int m = l + (r - l) / 2;
                Sort(arr, l, m);
                Sort(arr, m + 1, r);
                Merge(arr, l,m, r);
            }
        }

        void Merge(int[] arr, int l,int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i;
            for (i = 0; i < n1; i++)
                L[i] = arr[l + i];
            int j;
            for (j = 0; j < n2; j++)
                R[j] = arr[m + j + 1];
            i = 0;
            j = 0;
            int k = l;
            while(i<n1 && j<n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }  
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while(i<n1)
            {
                arr[k] = L[i];
                i++;k++;
            }
            while(j<n2)
            {
                arr[k] = R[j];
                j++;k++;
            }
        }

        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        // Driver code
        public static void Main(string[] args)
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            int[] arr1 = { 12, 11, 13, 5, 6, 7 };
            Console.WriteLine("Given Array");
            printArray(arr);
            MergerAndQuickSort ob = new MergerAndQuickSort();
            ob.Sort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array");
            printArray(arr);
            Console.WriteLine("\nSorted array");
            ob.quickSort(arr1, 0, arr1.Length - 1);
            printArray(arr1);
        }

        void quickSort(int[] arr, int l, int h)
        {
            if(l<h)
            {
                int pi = partition(arr, l, h);

                quickSort(arr, l, pi-1);
                quickSort(arr, pi + 1, h);
            }
        }

        private int partition(int[] arr, int l, int h)
        {
            int pivot = arr[h];
            int i = l - 1;
            for(int j=l;j<=h-1;j++)
            {
                if(arr[j]<pivot)
                {
                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, h);
            return (i + 1);
        }

        private void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }

	

}
