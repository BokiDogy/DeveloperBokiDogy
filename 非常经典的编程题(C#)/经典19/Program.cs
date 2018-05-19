using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典19
{
//    题目：打印出如下图案（菱形）   
//   *
//  ***
// *****
//*******
// *****
//  ***
//   *
//public class lianxi19
//    {
//        public static void main(String[] args)
//        {
//            int H = 7, W = 7;//高和宽必须是相等的奇数
//            for (int i = 0; i < (H + 1) / 2; i++)
//            {
//                for (int j = 0; j < W / 2 - i; j++)
//                {
//                    System.out.print(" ");
//                }
//                for (int k = 1; k < (i + 1) * 2; k++)
//                {
//                    System.out.print('*');
//                }
//                System.out.println();
//            }
//            for (int i = 1; i <= H / 2; i++)
//            {
//                for (int j = 1; j <= i; j++)
//                {
//                    System.out.print(" ");
//                }
//                for (int k = 1; k <= W - 2 * i; k++)
//                {
//                    System.out.print('*');
//                }
//                System.out.println();
//            }
//        }
//    }

    class Program
    {
        static void Main(string[] args)
        {
            int m = ShuRu("菱形的长度（奇数）m");
            int a = 1, b, c;
            for (a = 1; a <= m / 2 + 1; a++)
            {
                for (b = m / 2 + 1 - a; b > 0; b--)
                {
                    Console.Write(" ");
                }
                for (c = 1; c <= 2 * a - 1; c++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            for (a = 1; a <= m / 2; a++)
            {
                for (b = 1; b <= a; b++)
                {
                    Console.Write(" ");
                }
                for (c = m - 2 * a; c >= 1; c--)
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
