using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class ShellSort
    {
        public static void Shell(int[] array)
        {
            var len = array.Length;
            for (var d = len / 2; d > 0; d /= 2)
            {
                for (var i = d; i < len; i += d)
                {
                    for (var j = i + d; j >= d && j < len; j--)
                    {
                        if (array[j] < array[j - d])
                        {
                            //交换效率低下
                            SortingUtil.Swap(ref array[j], ref array[j - d]);
                        }
                    }
                }
            }
        }

        public static void Shell2(int[] array)
        {
            if (array == null) return;
            var len = array.Length;
            for (var skp = len / 2; skp > 0; skp /= 2)
            {
                //少一层分组循环，提高算法效率
                for (var i = skp; i < len; i++)
                {
                   var temp = array[i];
                    //直接插入排序
                    var indx = i - skp;

                    //while (indx >= 0 && array[indx] > temp)
                    //{
                    //    array[indx + skp] = array[indx];
                    //    indx -= skp;
                    //}

                    //for循环的效率比while循环效率高
                    for (; indx >= 0; indx -= skp)
                    {
                        if (temp > array[indx])
                            break;
                        array[indx + skp] = array[indx];
                    }
                    array[indx + skp] = temp;
                }
            }
        }

        public static void Shell3(int[] array)
        {
            if (array == null) return;
            var len = array.Length;
            for (var skp = len / 2; skp > 0; skp /= 2)
            {
                for (var i = 0; i < skp; i ++)
                {
                    for (var j = i+skp; j < len; j += skp)
                    {
                        var indx = j - skp;
                        var temp = array[j];
                        while (indx >= 0 && array[indx] > temp)
                        {
                            array[indx + skp] = array[indx];
                            indx -= skp;
                        }
                        array[indx + skp] = temp;
                    }
                }
            }
        }
    }
}
