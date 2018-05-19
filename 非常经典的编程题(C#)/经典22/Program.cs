using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典22
{
//    【程序22】   
//题目：利用递归方法求5!。   
//public class lianxi22
//    {
//        public static void main(String[] args)
//        {
//            int n = 5;
//            rec fr = new rec();
//            System.out.println(n + "! = " + fr.rec(n));
//        }
//    }
//    class rec
//    {
//        public long rec(int n)
//        {
//            long value = 0;
//            if (n == 1)
//            {
//                value = 1;
//            }
//            else
//            {
//                value = n * rec(n - 1);
//            }
//            return value;
//        }
//    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = ShuRu("一个正整数n");
            Console.WriteLine($"!{n}的值为：{JieCheng(n)}");
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
        public static decimal JieCheng(int n)
        {
            if (n == 1)
            {
                return Convert.ToDecimal(1);
            }
            else if (n > 1)
            {
                return Convert.ToDecimal(JieCheng(n - 1))* n;
            }
            else
            {
                return 0;
            }
        }
        public static decimal SumJieCheng(int n)
        {
            decimal sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += JieCheng(i);
            }
            return sum;
        }
    }
}
