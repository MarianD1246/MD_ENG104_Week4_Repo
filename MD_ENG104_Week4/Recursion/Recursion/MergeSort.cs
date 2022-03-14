using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class MergeSort
    {
        public static int[] MergeArraySort(int[] arr, int compareNo = 1)
        {
            int noOfMergeGroups = arr.Length / compareNo;
            int leftOverInts = arr.Length % compareNo;

            for (int x = 0; x < noOfMergeGroups;x++ )   //Runs code on all standard subgroups of array
            {
                for (int i = 0; i < compareNo; i++)  //This orders a piece of array from min to max
                {
                    arr[i +(x*compareNo)] = arr.Min();
                }
            }
            if(leftOverInts > 0)    //This orders the numbers in the remainder
            {
                for (int i = 0; i < leftOverInts; i++)  //This orders a piece of array from min to max
                {
                    arr[i + (arr.Length - leftOverInts)] = arr.Min();
                }
            }

            if (compareNo == arr.Length)    //If all the arrays have been merged return the array
                return arr;
            else
                return MergeArraySort(arr, compareNo * 2); //If the arrays aren't fully merged, merge them
        }

        public static int[] MergeArraySortRecursive(int[] arr)
        {
            if (arr.Length==1)
                return arr;

            return arr;
        }
    }
}

//private static int SumRecursive(int n)
//{
//    if (n == 1) return 1; // if we don't have this base case , we have infinite recursion and get stack overflow
//    int prev = SumRecursive(n - 1); //B
//    int sum = n + prev;
//    return sum;
//}
/*


 */