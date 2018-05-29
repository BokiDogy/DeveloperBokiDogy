using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典02
{
    //    【程序2】   
    //题目：判断101-200之间有多少个素数，并输出所有素数。 
    //程序分析：判断素数的方法：用一个数分别去除2到sqrt(这个数)，如果能被整除， 则表明此数不是素数，反之是素数。   
    //public class lianxi02
    //    {
    //        public static void main(String[] args)
    //        {
    //            int count = 0;
    //            for (int i = 101; i < 200; i += 2)
    //            {
    //                boolean b = false;
    //                for (int j = 2; j <= Math.sqrt(i); j++)
    //                {
    //                    if (i % j == 0) { b = false; break; }
    //                    else { b = true; }
    //                }
    //                if (b == true) { count++; System.out.println(i); }
    //            }
    //            System.out.println("素数个数是: " + count);
    //        }
    //    }

    class Program
    {
        static void Main(string[] args)
        {
            int x = ShuRu("m");
            int y = ShuRu("n");
            int a = x;
            x = x > y ? y : x;
            y = y > a ? y : a;
            int z = 1;
            for (int n = x; n <= y; n++)
            {
                bool iszhi = true;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        iszhi = false;
                        break;
                    }
                }
                if (iszhi)
                {
                    Console.WriteLine($"{x}-{y}间：第{z}项质数是{n}");
                    z++;
                }
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
