using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class InsertionSort
    {
        public static void InsertSort(int[] array)
        {
            if (array == null) return;
            var len = array.Length;
            for (var i = 0; i < len; i++)
            {
                for (var j = i + 1; j >0&&j<len; j--)
                {
                    if(array[j]<array[j-1])
                    {
                        SortingUtil.Swap(ref array[j], ref array[j - 1]);
                    }
                }
            }
        }
      

    }
}
