using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典21
{
    //    【程序21】   
    //题目：求1+2!+3!+...+20!的和
    //public class lianxi21
    //    {
    //        public static void main(String[] args)
    //        {
    //            long sum = 0;
    //            long fac = 1;
    //            for (int i = 1; i <= 20; i++)
    //            {
    //                fac = fac * i;
    //                sum += fac;
    //            }
    //            System.out.println(sum);
    //        }
    //    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = ShuRu("一个正整数n");
            int sum = 0, ji;
            for (int i = 1; i <= n; i++)
            {
                ji = 1;
                for (int j = 1; j <= i; j++)
                {
                    ji *= j;
                }
                sum += ji;
            }
            Console.WriteLine($"前{n}项!{n}的和为：{sum}");
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
