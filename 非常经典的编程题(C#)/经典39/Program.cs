using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典39
{
//【程序39】   
//题目：编写一个函数，输入n为偶数时，调用函数求1/2+1/4+...+1/n,当输入n为奇数时，调用函数1/1+1/3+...+1/n(利用指针函数)
////没有利用指针函数
//import java.util.*;
//    public class lianxi39
//    {
//        public static void main(String[] args)
//        {
//            Scanner s = new Scanner(System.in);
//            System.out.print("请输入一个正整数 n= ");
//            int n = s.nextInt();
//            System.out.println("相应数列的和为：" + sum(n));
//        }
//        public static double sum(int n)
//        {
//            double res = 0;
//            if (n % 2 == 0)
//            {
//                for (int i = 2; i <= n; i += 2)
//                {
//                    res += (double)1 / i;
//                }
//            }
//            else
//            {
//                for (int i = 1; i <= n; i += 2)
//                {
//                    res += (double)1 / i;
//                }
//            }
//            return res;
//        }
//    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = ShuRu("正整数n");
            double sum = QiuFenShuHe(n);
            string a = n % 2 == 0 ? "1/2+1/4+...+1/n" : "1/1+1/3+...+1/n";
            Console.WriteLine($"{a}={sum}");
            Console.ReadLine();
        }
        /// <summary>
        /// 输入n为偶数时，求1/2+1/4+...+1/n，n为奇数时，求1/1+1/3+...+1/n
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>求分数和sum</returns>
        public static double QiuFenShuHe(int n)
        {
            double sum = 0;
            for (int i=0;i<(n%2==0?(n/2):(n+1)/2);i++)
            {
                sum += 1.0d / (n - 2 * i);
            }
            return sum;
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
