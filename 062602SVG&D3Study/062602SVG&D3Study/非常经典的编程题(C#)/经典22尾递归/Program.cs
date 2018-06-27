using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典22尾递归
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = ShuRu("一个正整数n");
            Console.WriteLine($"!{n}的值为：{JieChengw(n,1)}");
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
        /// 求n的阶乘
        /// </summary>
        /// <param name="n">输入n</param>
        /// <returns>返回!n</returns>
        public static decimal JieChengw(int n, decimal res)
        {
            if (n == 1)
            {
                return res;
            }
            else if (n > 1)
            {
                return JieChengw(n - 1, res * n);
            }
            else
            {
                return 0;
            }
        }
    }
}