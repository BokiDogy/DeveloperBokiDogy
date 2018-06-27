using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典30
{
    //    【程序30】   
    //题目：有一个已经排好序的数组。现输入一个数，要求按原来的规律将它插入数组中。    
    ////此程序不好，没有使用折半查找插入
    //import java.util.*;
    //    public class lianxi30
    //    {
    //        public static void main(String[] args)
    //        {
    //            int[] a = new int[] { 1, 2, 6, 14, 25, 36, 37, 55 };
    //            int[] b = new int[a.length + 1];
    //            int t1 = 0, t2 = 0;
    //            int i = 0;
    //            Scanner s = new Scanner(System.in);
    //            System.out.print("请输入一个整数：");
    //            int num = s.nextInt();
    //            if (num >= a[a.length - 1])
    //            {
    //                b[b.length - 1] = num;
    //                for (i = 0; i < a.length; i++)
    //                {
    //                    b[i] = a[i];
    //                }
    //            }
    //            else
    //            {
    //                for (i = 0; i < a.length; i++)
    //                {
    //                    if (num >= a[i])
    //                    {
    //                        b[i] = a[i];
    //                    }
    //                    else
    //                    {
    //                        b[i] = num;
    //                        break;
    //                    }
    //                }
    //                for (int j = i + 1; j < b.length; j++)
    //                {
    //                    b[j] = a[j - 1];
    //                }
    //            }
    //            for (i = 0; i < b.length; i++)
    //            {
    //                System.out.print(b[i] + " ");
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
            Console.WriteLine("\n排序前的结果为：");
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
            for (int j = 1; j < a.Length; j++)
            {
                int k = a[j];
                int i = j - 1;
                while (i >= 0 && a[i] > k)
                {
                    a[i + 1] = a[i];
                    i--;
                    a[i + 1] = k;
                }
            }
            Console.WriteLine("\n\n排序后的结果为：");
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
            Console.WriteLine("\n");
            int x = ShuRu("一个数字n");
            int max = a.Length-1, min = 0,key = (a.Length - 1)/2,index;
            index = x > a[max] ? max+1 : 0;
            while (x<=a[max]&&x>=a[min]&&max-min>1)
            {
                if(x== a[key])
                {
                    min = key;
                    index = min+1;
                    break;
                }
                else if (x > a[key])
                {
                    min = key;
                    key = (max + min) / 2;
                }
                else
                {
                    max = key;
                    key = (max + min) / 2;
                }
                index = min+1;
            }
            int[] b = new int[n + 1];
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = i == index ? x : i < index ? a[i] : a[i-1];
            }
            Console.WriteLine($"\n\n将{x}插入a[]后的结果为：");
            Console.Write("\na[]=[");
            for (int i = 0; i < b.Length; i++)
            {
                if (i == index)
                {
                    if (i == b.Length - 1)
                    {
                        Console.Write($"|{b[i]}|]");
                    }
                    else
                    {
                        Console.Write($"|{b[i]}|,");
                    }
                }
                else
                {
                    if (i == b.Length - 1)
                    {
                        Console.Write($"{b[i]}]");
                    }
                    else
                    {
                        Console.Write($"{b[i]},");
                    }
                }
            }
            Console.WriteLine("\n");
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
        /// <summary>
        /// 求一个数m的n次幂
        /// </summary>
        /// <param name="n">输入底数m，指数n</param>
        /// <returns>输出m的n次幂x</returns>
        public static double QiuMi(float m, int n)
        {
            double x = 1;
            for (int i = 0; i < (n >= 0 ? n : -n); i++)
            {
                if (n > 0)
                {
                    x *= m;
                }
                else
                {
                    x /= m;
                }
            }
            return x;
        }
    }
}
