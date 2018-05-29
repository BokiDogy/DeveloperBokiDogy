using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典19巩固
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = ShuRu("沙漏的长度（奇数）m");
            int a = 1, b, c;
            for (a = 1; a <= m / 2 + 1; a++)
            {
                for (b = 1; b <a; b++)
                {
                    Console.Write(" ");
                }
                for (c = m - 2 * a+2; c >= 1; c--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                
            }
            for (a = 1; a <= m / 2; a++)
            {
                for (b = m / 2 - a; b >= 1; b--)
                {
                    Console.Write(" ");
                }
                for (c = 1; c <= 2*a+1; c++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
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
