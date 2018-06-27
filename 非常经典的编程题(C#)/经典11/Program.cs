using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典11
{
    //{【程序11】   
    //题目：有1、2、3、4四个数字，能组成多少个互不相同且无重复数字的三位数？都是多少？   
    //public class lianxi11
    //    {
    //        public static void main(String[] args)
    //        {
    //            int count = 0;
    //            for (int x = 1; x < 5; x++)
    //            {
    //                for (int y = 1; y < 5; y++)
    //                {
    //                    for (int z = 1; z < 5; z++)
    //                    {
    //                        if (x != y && y != z && x != z)
    //                        {
    //                            count++;
    //                            System.out.println(x * 100 + y * 10 + z);
    //                        }
    //                    }
    //                }
    //            }
    //            System.out.println("共有" + count + "个三位数");
    //        }
    //    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = ShuRu("任一数字n");
            int[] a = SaveWeiShu(n);
            int m = WeiShu(n);
            int count = 0;
            for (int x = 0; x < a.Length; x++)
            {
                for (int y = 0; y < a.Length; y++)
                {
                    for (int z = 0; z < a.Length; z++)
                    {
                        if (a[x] != a[y] && a[y] != a[z] && a[x] != a[z])
                        {
                            count++;
                            Console.WriteLine($"第{count}个三位数为：{a[x] * 100 + a[y] * 10 + a[z]}");
                        }
                    }
                }
            }
            Console.WriteLine($"共能组成{count}个三位数。");
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
        /// 求一个数字的位数
        /// </summary>
        /// <param name="n">输入一个数字n</param>
        /// <returns>返回位数i</returns>
        public static int WeiShu(int n)
        {
            int w = 1, i = 0;
            while (n / w != 0)
            {
                w *= 10;
                i++;
            }
            return i;
        }
        /// <summary>
        /// 将一个数字各位数字存入int数组
        /// </summary>
        /// <param name="n">输入一个数字n</param>
        /// <returns>返回数组a</returns>
        public static int[] SaveWeiShu(int n)
        {
            int w = 1, i = 0;
            int[] a = new int[WeiShu(n)];
            while (n / w != 0)
            {
                a[i] = n / w % 10;
                w *= 10;
                i++;
            }
            return a;
        }
    }
}
