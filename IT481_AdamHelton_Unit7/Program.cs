using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace IT481_AdamHelton_Unit7
{
    class Program
    {
        private static Stopwatch stopwatch;
        private static bool debug = false;
        
        static void Main(string[] args)
        {
            int type = 1;

            int[] smallArray = getArray(10, 100);

            int[] newSmallArray = new int[smallArray.Length];
            Array.Copy(smallArray, 0, newSmallArray, 0, newSmallArray.Length);
            
            int[] quickSmallArray = new int[newSmallArray.Length];
            Array.Copy(newSmallArray, 0, quickSmallArray, 0, quickSmallArray.Length);

            String size = "small";
            runSortArray(smallArray, size, type);
            
            
            
            int[] mediumArray = getArray(100, 100);

            int[] newMediumArray = new int[mediumArray.Length];
            Array.Copy(mediumArray, 0, newMediumArray, 0, newMediumArray.Length);
            
            int[] quickMediumArray = new int[newMediumArray.Length];
            Array.Copy(newMediumArray, 0, quickMediumArray, 0, quickMediumArray.Length);

            size = "medium";
            runSortArray(mediumArray, size, type);
            
            
            int[] largeArray = getArray(10000, 100);

            int[] newLargeArray = new int[largeArray.Length];
            Array.Copy(largeArray, 0, newLargeArray, 0, newLargeArray.Length);
            
            int[] quickLargeArray = new int[newLargeArray.Length];
            Array.Copy(newLargeArray, 0, quickLargeArray, 0, quickLargeArray.Length);

            size = "large";
            runSortArray(largeArray, size, type);

            newSmallArray = onlyUniqueElements(newSmallArray);
            size = "new small unique";
            runSortArray(newSmallArray, size, type);

            newMediumArray = onlyUniqueElements(newMediumArray);
            size = "new medium unique";
            runSortArray(newMediumArray, size, type);

            newLargeArray = onlyUniqueElements(newLargeArray);
            size = "new large unique";
            runSortArray(newLargeArray, size, type);



            type = 2;

            size = "quick small";
            runSortArray(quickSmallArray, size, type);
            
            size = "quick medium";
            runSortArray(quickMediumArray, size, type);

            size = "quick large";
            runSortArray(quickLargeArray, size, type);

            Console.Read();
        }

        private static int[] getArray(int size, int randomMaxSize)
        {
            int[] myArray = new int[size];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = GetRandomNumber(1, randomMaxSize);
            }

            return myArray;
        }

        private static void runSortArray(int[] arr, String size, int type)
        {
            long elapsedTime = 0;

            String sort = null;
            if (type == 1)
            {
                sort = "bubble";
            }
            else if (type == 2)
            {
                sort = "quick";
            }

            if (debug)
            {
                Console.WriteLine("Array before the " + sort + " sort");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            stopwatch = Stopwatch.StartNew();
            if (type == 1)
            {
                bubbleSort(arr);
            }
            else if (type == 2)
            {
                int low = 0;
                int high = arr.Length - 1;
                sortAsc(arr, low, high);
            }
            Console.WriteLine();

            if (debug)
            {
                Console.WriteLine("Array after the " + sort + " sort");

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            
            stopwatch.Stop();

            elapsedTime = stopwatch.ElapsedTicks;
            long frequency = Stopwatch.Frequency;
            long nanosecondsPerTick = (1000L * 1000L * 1000L) / frequency;
            elapsedTime = elapsedTime * nanosecondsPerTick;
            Console.WriteLine("\n");

            Console.WriteLine("The run time is for the " + size + " array in nanoseconds is " + elapsedTime);
            Console.WriteLine("\n\n");
        }
    }
}