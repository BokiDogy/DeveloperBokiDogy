﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典36
{
    //    【程序36】   
    //题目：有n个整数，使其前面各数顺序向后移m个位置，最后m个数变成最前面的m个数
    //import java.util.Scanner;
    //public class lianxi36
    //    {
    //        public static void main(String[] args)
    //        {
    //            int N = 10;
    //            int[] a = new int[N];
    //            Scanner s = new Scanner(System.in);
    //            System.out.println("请输入10个整数：");
    //            for (int i = 0; i < N; i++)
    //            {
    //                a[i] = s.nextInt();
    //            }
    //            System.out.print("你输入的数组为：");
    //            for (int i = 0; i < N; i++)
    //            {
    //                System.out.print(a[i] + " ");
    //            }
    //            System.out.print("\n请输入向后移动的位数：");
    //            int m = s.nextInt();
    //            int[] b = new int[m];
    //            for (int i = 0; i < m; i++)
    //            {
    //                b[i] = a[N - m + i];
    //            }
    //            for (int i = N - 1; i >= m; i--)
    //            {
    //                a[i] = a[i - m];
    //            }
    //            for (int i = 0; i < m; i++)
    //            {
    //                a[i] = b[i];
    //            }
    //            System.out.print("位移后的数组是：");
    //            for (int i = 0; i < N; i++)
    //            {
    //                System.out.print(a[i] + " ");
    //            }
    //        }
    //    }

    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] a = new int[n];
            Console.WriteLine($"请输入任意{a.Length}个数字：");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"请输入第{i + 1}个数:");
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (i == a.Length - 1)
                {
                    Console.WriteLine("输入结束");
                }
            }
            Console.WriteLine("排序前的结果为：");
            Console.Write("\na[]=[");
            for (int i = 0; i < a.Length; i++)
            {
                if (i == a.Length - 1)
                {
                    Console.Write($"{a[i]}]");
                }
                else
                {
                    Console.Write($"{a[i]},");
                }
            }
            Console.WriteLine("");
            int m = ShuRu("位移的位数m");
            while (m > a.Length / 2)
            {
                Console.WriteLine("您输入的位数太大，请重新输入：");
                m = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < m; i++)
            {
                int temp = a[i];
                a[i] = a[a.Length - m + i];
                a[a.Length - m + i] = temp;
            }
            Console.WriteLine("位移后的结果为：");
            Console.Write("\na[]=[");
            for (int i = 0; i < a.Length; i++)
            {
                if (i == a.Length - 1)
                {
                    Console.Write($"{a[i]}]");
                }
                else
                {
                    Console.Write($"{a[i]},");
                }
            }
            Console.ReadLine();
        }
        /// <summary>
        /// 输入函数
        /// </summary>
        /// <param name="des">屏幕提示</param>
        /// <returns>输入的x值</returns>
        public static int ShuRu(string des)
        {
            int x;
            Console.Write($"请输入{des}=");
            return x = Convert.ToInt32(Console.ReadLine());
        }
    }
}
