using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public static class SortTest
    {
        public static void TestShell()
        {
            int[] array1 = SortingUtil.InitArray();
            int[] array2 = new int[array1.Length];
            array1.CopyTo(array2,0);
            Console.WriteLine("排序前数组：");
            SortingUtil.ConsolePartArray(array1);
            TimeSpan t0=new TimeSpan(DateTime.Now.Ticks);
            ShellSort.Shell2(array1);
            TimeSpan t1 = new TimeSpan(DateTime.Now.Ticks);
            ShellSort.Shell3(array2);
            TimeSpan t2 = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine("Shell2排序后数组：");
            SortingUtil.ConsolePartArray(array1);
            Console.WriteLine("Shell3排序后数组：");
            SortingUtil.ConsolePartArray(array2);
            SortingUtil.ConsoleTime("Shell2",t1-t0);
            SortingUtil.ConsoleTime("Shell4", t2 - t1);
            SortingUtil.ConsoleTime(t1 - t0,t2 - t1);
        }

        public static void TestBubble()
        {
            int[] array1 = SortingUtil.InitArray();
            int[] array2 = new int[array1.Length];
            array1.CopyTo(array2, 0);
            Console.WriteLine("排序前数组：");
            SortingUtil.ConsolePartArray(array1);
            TimeSpan t0 = new TimeSpan(DateTime.Now.Ticks);
            BubbleSort.Bubble(array1);
            TimeSpan t1 = new TimeSpan(DateTime.Now.Ticks);
            BubbleSort.Bubble2(array2);
            TimeSpan t2 = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine("Shell排序后数组：");
            SortingUtil.ConsolePartArray(array1);
            Console.WriteLine("Bubble排序后数组：");
            SortingUtil.ConsolePartArray(array2);
            SortingUtil.ConsoleTime("Bubble", t1 - t0);
            SortingUtil.ConsoleTime("Bubble2", t2 - t1);
            SortingUtil.ConsoleTime(t1 - t0, t2 - t1);
        }

        public static void TestQuick()
        {
            int[] array1 = SortingUtil.InitArray();
            int[] array2 = new int[array1.Length];
            array1.CopyTo(array2, 0);
            Console.WriteLine("排序前数组：");
            SortingUtil.ConsolePartArray(array1);
            TimeSpan t0 = new TimeSpan(DateTime.Now.Ticks);
            ShellSort.Shell2(array1);
            TimeSpan t1 = new TimeSpan(DateTime.Now.Ticks);
            QuickSort.Quick(ref array2,0,array2.Length-1);
            TimeSpan t2 = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine("Shell排序后数组：");
            SortingUtil.ConsolePartArray(array1);
            Console.WriteLine("Quick排序后数组：");
            SortingUtil.ConsolePartArray(array2);
            SortingUtil.ConsoleTime("Shell2", t1 - t0);
            SortingUtil.ConsoleTime("Quick", t2 - t1);
            SortingUtil.ConsoleTime(t1 - t0, t2 - t1);
        }
    }
}
