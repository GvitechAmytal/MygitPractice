using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class QuickSort
    {
        public static void Quick<T>(ref T[] array,int low ,int high) where T : IComparable, IComparable<T>
        {
            if (array == null) return;
            if (low >= high) return;
            var indx= QSort(ref array, low, high);
            Quick(ref array, low, indx - 1);
            Quick(ref array,indx +1, high);
        }

        private static int QSort<T>(ref T[] array, int low, int high) where T : IComparable, IComparable<T>
        {
            T key = array[low];
            while (low < high)
            {
                /*从后向前搜索比key小的值*/
                while (array[high].CompareTo(key)>0 && high > low)
                    --high;
                /*比key小的放左边*/
                array[low] = array[high];
                /*从前向后搜索比key大的值，比key大的放右边*/
                while (array[low].CompareTo(key) <=0 && high > low)
                    ++low;
                /*比key大的放右边*/
                array[high] = array[low];
            }
            /*左边都比key小，右边都比key大。//将key放在游标当前位置。//此时low等于high */
            array[low] = key;
            return high;
        }
    }
}
