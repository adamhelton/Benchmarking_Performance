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
            
            
            
            
            
            
            int[] mediumArray = getArray(10, 100);

            int[] newMediumArray = new int[mediumArray.Length];
            Array.Copy(mediumArray, 0, newMediumArray, 0, newMediumArray.Length);
            
            int[] quickMediumArray = new int[newMediumArray.Length];
            Array.Copy(newMediumArray, 0, quickMediumArray, 0, quickMediumArray.Length);

            size = "medium";
            runSortArray(MediumArray, size, type);

        }
    }
}