using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GregPostingsST10114245_PROG3B_POE.WorkingGameClasses
{
    class WGSortingAlgorithims
    {

        //Bubble sort

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


        //Easy Sorts

        #region Easy Sorts

        public void EasySortWithLINQ(ListBox lb)
        {
            WGDeweyDecimalNumberGenerator d = new WGDeweyDecimalNumberGenerator();

            var sortedList = d.deweyNums.OrderBy(x => x).ToList();

            foreach (var num in sortedList)
            {

                lb.Items.Add(num);
            }
        }

        private WGDeweyDecimalNumberGenerator wGDeweyDecimalNumberGenerator = new WGDeweyDecimalNumberGenerator();
        public void EasySort(ListBox lb)
        {
            lb.Items.Clear();
            wGDeweyDecimalNumberGenerator.deweyNums.Sort();

            foreach (var num in wGDeweyDecimalNumberGenerator.deweyNums)
            {
                lb.Items.Add(num);
            }
        }

        #endregion

    }
}
//---------------------------------------ooo000 END OF FILE 000ooo--------------------------------------//