using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 经典09改进算法
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            int n = ShuRu("一个正整数n");
            WriteLine($"0-{n}的之间的完数为：");
            for (int i = 2; i <= n; i++)
            {
                for (int k = 2; (k * k) <= i; k++)
                {
                    if (i % k == 0)
                    {
                        s = s + k + i / k;
                    }
                }
                if (s == i - 1)
                {
                    WriteLine($"{i}为完数");
                }
                s = 0;
            }
            ReadLine();
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
