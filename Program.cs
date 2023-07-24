using System;

using System.Diagnostics;


namespace Assignment_14
{
    internal class Program
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            for(int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
        }

        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            //int arrayElements;
            //Console.WriteLine("Enter the no. of elements for array");
            //arrayElements = int.Parse(Console.ReadLine());
            //int[] arr = new int[arrayElements];

            //Console.WriteLine("Enter the Values of Array");
            //for (int i = 0; i < arrayElements; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            int[] arr1 = { 500,100,1000,5000,999};
            int[] arr2 = { 1000,100, 500, 5000, 999 };

            Console.Write("Before bubble sorting Arraylist: \n " );
           
            Print(arr1);

            //Bubble Sorting
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            BubbleSort(arr1);
            stopwatch.Stop();
            Console.WriteLine("After bubble sorting Arraylist:\n");
            
            Print(arr1);

            Console.WriteLine($"Array {arr1.Length} Time Taken in Bubble Sort {stopwatch.Elapsed.TotalMilliseconds} millieseconds");
            Console.WriteLine("\n\n\n");
            //Insertion Sort
            Stopwatch stopwatch1 = new Stopwatch();
            Console.WriteLine("*******************Insertion sort**********************\n");

            Console.Write("Before insertion  sorting :\n ");
           
            Print(arr2);

            stopwatch1.Start();
            InsertionSort(arr2);
            stopwatch1.Stop();
            Console.WriteLine(" After Insertion Sorting:\n ");
           
            Print(arr2);

            Console.WriteLine($"Array {arr2.Length} Time Taken in Insertion Sort {stopwatch1.Elapsed.TotalMilliseconds} millieseconds");

            Console.ReadKey();
            

            
        }
    }
}








/*Advantages of Bubble Sort:

Simple implementation and easy to understand.
In some cases, Bubble Sort can perform well on small lists or nearly sorted lists.
Requires minimal additional memory space for sorting.



Disadvantages of Bubble Sort:

Bubble Sort has a time complexity of O(n^2) in the worst and average cases, making it inefficient for large datasets.
It performs poorly compared to more efficient sorting algorithms like Merge Sort, Quick Sort, and Heap Sort.
Bubble Sort's performance degrades significantly as the input size increases.*/

