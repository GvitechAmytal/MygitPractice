using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
   public class SortingUtil
    {
        public const int Len= 10000000;
        private static Random rd = new Random();

        public static void Move<T>(ref T[] array, int startIndex,int count,int step=1) where T : IComparable, IComparable<T>, IComparer<T>
        {
            int len = 0;
            if (array == null || (len = array.Length) < 1 || startIndex < 0 || count < 1 || step < 1 || startIndex + count + step < len) return;
            var insertIndex = startIndex + count;
            var temp = array[insertIndex];
            T[] temps = new T[step];
            bool isMultiStep = step > 1;
            if (isMultiStep)
            {
                for (var i = 0; i < step; i++)
                {
                    temps[i] = array[i + insertIndex];
                }
            }
            var endIndex = startIndex + step;
            for (var i = insertIndex - 1; i >= startIndex; i--)
            {
                array[i + step] = array[i];
                if (i < endIndex)
                    array[i] = isMultiStep ? temps[i - startIndex] : temp;
            }
        }
        public static void Swap<T>(ref T one, ref T other)
        {
            T temp = one;
            one = other;
            other = temp;
        }
        public static void ConsoleArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + "  ");
            }
            Console.Write("\n");
        }

        public static void ConsolePartArray(int[] array)
        {
            Console.WriteLine("<{0}><{1}><{2}>",array[0],array[(array.Length)/2],array[array.Length-1]);
        }
        public static void ConsoleTime(string pre,TimeSpan t)
        {
            Console.WriteLine("{0}耗时{1}ms", pre, t.TotalMilliseconds);
        }
        public static void ConsoleTime(TimeSpan t1, TimeSpan t2)
        {
            Console.WriteLine("时间差{0}ms",(t2-t1).TotalMilliseconds);
            Console.WriteLine("效率{0}{1}%", t2 < t1 ? "高":"低",(t2 < t1 ? (t1 - t2).TotalMilliseconds / t1.TotalMilliseconds : (t2-t1).TotalMilliseconds / t1.TotalMilliseconds)*100);
        }
        public static int[] InitArray()
        {
            int[] array = new int[Len];
            for (var i = 0; i < Len; i++)
            {
                array[i]=rd.Next();
            }
            return array;
        }
    }
}
