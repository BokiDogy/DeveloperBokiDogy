using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典21递归
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = ShuRu("一个正整数n");
            Console.WriteLine($"前{n}项!{n}的和为：{SumJieCheng(n)}");
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
        public static long JieCheng(int n)
        {
            if(n==1)
            {
                return Convert.ToInt64(1);
            }
            else if(n>1)
            {
                return Convert.ToInt64(JieCheng(n - 1))* n;
            }
            else
            {
                return 0;
            }
        }
        public static long SumJieCheng(int n)
        {
            long sum=0;
            for(int i=1;i<=n;i++)
            {
                sum += JieCheng(i);
            }
            return sum;
        }
    }
}
