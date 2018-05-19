using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典13扩展
{
    //    【程序13】   
    //题目：一个整数，它加上100后是一个完全平方数，再加上168又是一个完全平方数，请问该数是多少？   
    //public class lianxi13
    //    {
    //        public static void main(String[] args)
    //        {
    //            for (int x = 1; x < 100000; x++)
    //            {
    //                if (Math.sqrt(x + 100) % 1 == 0)
    //                {
    //                    if (Math.sqrt(x + 268) % 1 == 0)
    //                    {
    //                        System.out.println(x + "加100是一个完全平方数，再加168又是一个完全平方数");
    //                    }
    //                }
    //            }
    //        }
    //    }

    //    /*按题意循环应该从-100开始（整数包括正整数、负整数、零），这样会多一个满足条件的数-99。
    //    但是我看到大部分人解这道题目时都把题中的“整数”理解成正整数，我也就随大流了。*/

    class Program
    {
        static void Main(string[] args)
        {

            int m = ShuRu("第一个加数m");
            int n = ShuRu("第二个加数n");
            int x = -m, i = 0;
            while (x <= (n + 1) * (n + 1) / 4)
            {
                if ((Math.Sqrt(x + m) % 1 == 0) && (Math.Sqrt(x + m + n) % 1 == 0))
                {
                    i++;
                    Console.WriteLine($"第{i}个解为x={x}");
                }
                x++;
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