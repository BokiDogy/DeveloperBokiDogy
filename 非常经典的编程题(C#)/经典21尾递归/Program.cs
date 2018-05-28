using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典21尾递归
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = ShuRu("一个正整数n");
            Console.WriteLine($"前{n}项!{n}的和为：{SumJieChengw(n,1)}");
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
        public static long JieChengw(int n,long res)
        {
            if (n == 1)
            {
                return res;
            }
            else 
            {
                return JieChengw(n - 1,res*n);
            }
        }
        public static long SumJieChengw(int n,long rec)
        {
            if(n==1)
            {
                return rec;
            }
           else
            {
                return SumJieChengw(n - 1, rec + JieChengw(n, 1));
            }
        }
    }
}
