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
namespace GregPostingsST10114245_PROG3B_POE.Classes
{
    //Class
    class SortingAlgorithim
    {

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


        public static void BubbleSort<T>(T[] array) where T : IComparable
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
        

        private static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

        #endregion


        #region Easy Sorts

        public void EasySortWithLINQ(ListBox lb)
        {
            DeweyDecimalNumberGenerator d = new DeweyDecimalNumberGenerator();

            var sortedList = d.deweyNums.OrderBy(x => x).ToList();

            foreach (var num in sortedList)
            {
                
                lb.Items.Add(num);
            }
        }

        public void EasySort(ListBox lb)
        {
            DeweyDecimalNumberGenerator d = new DeweyDecimalNumberGenerator();

            d.deweyNums.Sort();

            foreach (var num in d.deweyNums)
            {
                lb.Items.Add(num);
            }
        }

        #endregion

    }
}
//---------------------------------------ooo000 END OF FILE 000ooo--------------------------------------//