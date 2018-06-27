using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典17
{
    //    【程序17】   
    //题目：猴子吃桃问题：猴子第一天摘下若干个桃子，当即吃了一半，还不瘾，又多吃了一个 第二天早上又将剩下的桃子吃掉一半，又多吃了一个。以后每天早上都吃了前一天剩下 的一半零一个。到第10天早上想再吃时，见只剩下一个桃子了。求第一天共摘了多少。   
    //public class lianxi17
    //    {
    //        public static void main(String[] args)
    //        {
    //            int x = 1;
    //            for (int i = 2; i <= 10; i++)
    //            {
    //                x = (x + 1) * 2;
    //            }
    //            System.out.println("猴子第一天摘了 " + x + " 个桃子");
    //        }
    //    }

    class Program
    {
        static void Main(string[] args)
        {
            int m = 0;
            while (f(10, m) < 1)
            {
                m++;
            }
            Console.WriteLine($"第一天的桃子数为：{m}");
            Console.ReadLine();
        }
        /// <summary>
        /// 第n天有m个桃子，求第1天的桃子个数
        /// </summary>
        /// <param name="n">天数n</param>
        /// <param name="m">初始桃子数m</param>
        /// <returns>返回第1天的桃子数</returns>
        public static float f(int n, int m)
        {
            if (n == 1)
            {
                return m;
            }
            else if (n > 1)
            {
                return (f(n - 1, m) / 2.0f - 1);
            }
            else
            {
                return 0;
            }
        }
    }
}
