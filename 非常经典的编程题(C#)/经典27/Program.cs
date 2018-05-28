using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典27
{
//    【程序27】   
//题目：求100之内的素数
////使用除sqrt(n)的方法求出的素数不包括2和3
//public class lianxi27
//    {
//        public static void main(String[] args)
//        {
//            boolean b = false;
//            System.out.print(2 + " ");
//            System.out.print(3 + " ");
//            for (int i = 3; i < 100; i += 2)
//            {
//                for (int j = 2; j <= Math.sqrt(i); j++)
//                {
//                    if (i % j == 0)
//                    {
//                        b = false;
//                        break;
//                    }
//                    else { b = true; }
//                }
//                if (b == true) { System.out.print(i + " "); }
//            }
//        }
//    }
//    //该程序使用除1位素数得2位方法，运行效率高通用性差。
//    public class lianxi27a
//    {
//        public static void main(String[] args)
//        {
//            int[] a = new int[] { 2, 3, 5, 7 };
//            for (int j = 0; j < 4; j++) System.out.print(a[j] + " ");
//            boolean b = false;
//            for (int i = 11; i < 100; i += 2)
//            {
//                for (int j = 0; j < 4; j++)
//                {
//                    if (i % a[j] == 0)
//                    {
//                        b = false;
//                        break;
//                    }
//                    else { b = true; }
//                }
//                if (b == true) { System.out.print(i + " "); }
//            }
//        }
//    }

    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 2; n <= 100; n++)
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
                    Console.WriteLine($"{n}是质数");
                }
            }
            Console.ReadLine();
        }
    }
}
