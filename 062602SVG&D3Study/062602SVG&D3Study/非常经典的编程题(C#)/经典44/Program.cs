using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典44
{
    //    【程序44】   
    //题目：一个偶数总能表示为两个素数之和。   
    ////由于用除sqrt(n)的方法求出的素数不包括2和3，
    ////因此在判断是否是素数程序中人为添加了一个3。
    //import java.util.*;
    //    public class lianxi44
    //    {
    //        public static void main(String[] args)
    //        {
    //            Scanner s = new Scanner(System.in);
    //            int n, i;
    //            do
    //            {
    //                System.out.print("请输入一个大于等于6的偶数：");
    //                n = s.nextInt();
    //            } while (n < 6 || n % 2 != 0);   //判断输入是否是>=6偶数,不是,重新输入
    //            fun fc = new fun();
    //            for (i = 2; i <= n / 2; i++)
    //            {
    //                if ((fc.fun(i)) == 1 && (fc.fun(n - i) == 1))
    //                {
    //                    int j = n - i;
    //                    System.out.println(n + " = " + i + " + " + j);
    //                } //输出所有可能的素数对
    //            }
    //        }
    //    }
    //    class fun
    //    {
    //        public int fun(int a)    //判断是否是素数的函数
    //        {
    //            int i, flag = 0;
    //            if (a == 3) { flag = 1; return (flag); }
    //            for (i = 2; i <= Math.sqrt(a); i++)
    //            {
    //                if (a % i == 0) { flag = 0; break; }
    //                else flag = 1;
    //            }
    //            return (flag);//不是素数,返回0,是素数,返回1
    //        }
    //    }
    //    //解法二
    //    import java.util.*;
    //    public class lianxi44
    //    {
    //        public static void main(String[] args)
    //        {
    //            Scanner s = new Scanner(System.in);
    //            int n;
    //            do
    //            {
    //                System.out.print("请输入一个大于等于6的偶数：");
    //                n = s.nextInt();
    //            } while (n < 6 || n % 2 != 0);   //判断输入是否是>=6偶数,不是,重新输入
    //            for (int i = 3; i <= n / 2; i += 2)
    //            {
    //                if (fun(i) && fun(n - i))
    //                {
    //                    System.out.println(n + " = " + i + " + " + (n - i));
    //                } //输出所有可能的素数对
    //            }
    //        }
    //        static boolean fun(int a)
    //        {    //判断是否是素数的函数
    //            boolean flag = false;
    //            if (a == 3) { flag = true; return (flag); }
    //            for (int i = 2; i <= Math.sqrt(a); i++)
    //            {
    //                if (a % i == 0) { flag = false; break; }
    //                else flag = true;
    //            }
    //            return (flag);
    //        }
    //    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = ShuRu("一个偶数m");
            int m;
            if (n % 2 == 0)
            {
                m = n;
            }
            else
            {
                Console.WriteLine("您输入的是一个奇数，请再输入一遍");
                m = ShuRu("一个偶数m");
            }
            //int sum = 0;
            int[] ZhiShu = ZhiShuShuZu(m);
            for (int i = 0; i < ZhiShu.Length; i++)
            {
                if (ZhiShu[i] == 0)
                {
                    break;
                }
                for (int j = 0; j < ZhiShu.Length; j++)
                {
                    if (ZhiShu[j] == 0)
                    {
                        break;
                    }
                    if (ZhiShu[i] + ZhiShu[j] == m)
                    {
                        Console.WriteLine($"{m}={ZhiShu[i]}+{ZhiShu[j]}");
                    }
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
        /// <summary>
        /// 求0-m间的质数
        /// </summary>
        /// <param name="m">输入m</param>
        /// <returns>返回存储0-m间质数的数组a,a的长度为m/2，即有空值</returns>
        public static int[] ZhiShuShuZu(int m)
        {
            int[] a = new int[m / 2];
            int x = 0;
            for (int n = 2; n <= m; n++)
            {
                bool iszhi = true;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        iszhi = false;
                        break;
                    }
                }
                if (iszhi)
                {
                    a[x] = n;
                    x++;
                }
            }
            return a;
        }
    }
}
