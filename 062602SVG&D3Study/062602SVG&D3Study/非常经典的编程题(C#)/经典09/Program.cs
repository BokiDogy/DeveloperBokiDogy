using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 经典09
{
//    题目：一个数如果恰好等于它的因子之和，这个数就称为 "完数 "。例如6=1＋2＋3.编程 找出1000以内的所有完数。   
//public class lianxi09
//    {
//        public static void main(String[] args)
//        {
//            System.out.println("1到1000的完数有： ");
//            for (int i = 1; i < 1000; i++)
//            {
//                int t = 0;
//                for (int j = 1; j <= i / 2; j++)
//                {
//                    if (i % j == 0)
//                    {
//                        t = t + j;
//                    }
//                }
//                if (t == i)
//                {
//                    System.out.print(i + "     ");
//                }
//            }
//        }

        class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            int n=ShuRu("一个正整数n");
            WriteLine($"0-{n}的之间的完数为：");
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= i / 2; k++)
                {
                    if(i % k == 0) 
                    {
                        s += k;
                    }
                    else
                    {
                        break;
                    }
                }
                if (s == i)
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
