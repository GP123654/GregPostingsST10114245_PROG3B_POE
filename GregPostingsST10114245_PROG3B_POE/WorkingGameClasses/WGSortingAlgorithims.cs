/*
 * Done By: Greg Postings ST10114245 
 * Module: PROG 3B
 * Class: BCA3 G7
 * Task: POE Task 1
 * Start Date and Time: 10 September 2022 at 14:30
 * Finish Date and Time: 21 September 2022 at 16:45
 * 
 */


//Imports
using System;
using System.Linq;
using System.Windows.Forms;

//Package
namespace GregPostingsST10114245_PROG3B_POE.WorkingGameClasses
{
    //Class
    class WGSortingAlgorithims
    {

        //Bubble Sort

        #region Bubble Sort

        //public void BubbleSort(string[] unsortedList)
        //{
        //    double temp;
        //    for (int i = 0; i < unsortedList.Length - 1; i++)
        //    {
        //        for (int j = 0; j < unsortedList.Length - (1 + i); j++)
        //        {
        //            if (unsortedList[j] > unsortedList[j + 1])
        //            {
        //                temp = unsortedList[j + 1];
        //                unsortedList[j + 1] = unsortedList[j];
        //                unsortedList[j] = temp;
        //            }
        //        }
        //    }
        //}


        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Bubble Sorting Method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        public void BubbleSort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Swapping Method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="first"></param>
        /// <param name="second"></param>
        private static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

        #endregion


        //Quick Sort

        #region Quick Sort

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Quick Sorting Method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        public void QuickSort<T>(T[] array) where T : IComparable
        {
            Sort(array, 0, array.Length - 1);
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Sort Method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        private static T[] Sort<T>(T[] array, int lower, int upper) where T : IComparable
        {
            if (lower < upper)
            {
                int p = Partition(array, lower, upper);
                Sort(array, lower, p);
                Sort(array, p + 1, upper);
            }
            return array;
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Partition Method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        private static int Partition<T>(T[] array, int lower, int upper) where T : IComparable
        {
            int i = lower;
            int j = upper;
            T pivot = array[lower];
            // or: T pivot = array[(lower + upper) / 2];
            do
            {
                while (array[i].CompareTo(pivot) < 0) { i++; }
                while (array[j].CompareTo(pivot) > 0) { j--; }
                if (i >= j) { break; }
                Swap(array, i, j);
            }
            while (i <= j);
            return j;
        }

        #endregion


        //Easy Sorts

        #region Easy Sorts

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Creating an object of the WGDeweyDecimalNumberGenerator class
        /// </summary>
        private WGDeweyDecimalNumberGenerator wGDeweyDecimalNumberGenerator = new WGDeweyDecimalNumberGenerator();

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Using LINQ to sort a specified listBox
        /// </summary>
        /// <param name="lb"></param>
        public void EasySortWithLINQ(ListBox lb)
        {
            //Creating a variable to store the new sorted List using LINQ
            var sortedList = wGDeweyDecimalNumberGenerator.deweyNums.OrderBy(x => x).ToList();

            foreach (var num in sortedList)
            {
                //Adds the numbers to a specified listBox
                lb.Items.Add(num);
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Using the Sort method to sort a specified listBox
        /// </summary>
        /// <param name="lb"></param>
        public void EasySort(ListBox lb)
        {
            //Clears the items from a specified listBox
            lb.Items.Clear();
            //Sorting the deweyNums List
            wGDeweyDecimalNumberGenerator.deweyNums.Sort();

            foreach (var num in wGDeweyDecimalNumberGenerator.deweyNums)
            {
                //Adds the numbers to a specified listBox
                lb.Items.Add(num);
            }
        }

        #endregion

    }
}
//---------------------------------------ooo000 END OF FILE 000ooo--------------------------------------//