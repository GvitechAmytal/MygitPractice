using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class BubbleSort
    {
        public static void Bubble<T>(T[] array) where T : IComparable, IComparable<T>
        {
            if (array == null) return;
            var len = array.Length;
            //比较len-1次
            for (var i = 0; i < len - 1; i++)
            {
                bool changed = false;
                for (var j = 0; j < len - 1 - i; j++)
                {
                    //循环比较
                    //交换相邻两个数的排序
                    //直到将最大的数排到未排序的末尾
                    var temp = array[j];
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        changed = true;
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
                if (!changed)
                    break;
            }
        }
        public static void Bubble2<T>(T[] array) where T : IComparable, IComparable<T>
        {
            if (array == null) return;
            var len = array.Length;
            for (var i = 0; i < len; i++)
            {
                var changed = false;
                for (var j = len - 1; j > i; j--)
                {
                    var temp = array[j];
                    if (array[j].CompareTo(array[j - 1])<0)
                    {
                        changed = true;
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
                if (!changed)
                    break;
            }
        }
    }
}
