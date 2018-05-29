using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 经典06
{
    //{【程序6】   
    //题目：输入两个正整数m和n，求其最大公约数和最小公倍数。   
    ///**在循环中，只要除数不等于0，用较大数除以较小的数，将小的一个数作为下一轮循环的大数，取得的余数作为下一轮循环的较小的数，如此循环直到较小的数的值为0，返回较大的数，此数即为最大公约数，最小公倍数为两数之积除以最大公约数。* /
    //import java.util.*;
    //public    class     lianxi06     { 
    //public static void main(String[] args) {
    //int     a ,b,m;
    //Scanner s = new Scanner(System.in);
    //System.out.print( "键入一个整数： "); 
    //a = s.nextInt();
    //System.out.print( "再键入一个整数： "); 
    //b = s.nextInt();
    //      deff cd = new deff();
    //      m = cd.deff(a,b);
    //      int n = a * b / m;
    //      System.out.println("最大公约数: " + m);
    //      System.out.println("最小公倍数: " + n);
    //} 
    //}
    //class deff{
    //public int deff(int x, int y) {
    //     int t;
    //     if(x < y) {
    //      t = x;
    //      x = y;
    //      y = t;
    //     }  
    //     while(y != 0) {
    //      if(x == y) return x;
    //      else {
    //       int k = x % y;
    //       x = y;
    //       y = k;
    //      }
    //     }
    //     return x;
    //}
    //} 

    class Program
    {
        static void Main(string[] args)
        {
            int m = ShuRu("m");
            int n = ShuRu("n");
            float i;
            if (n % m == 0 || m % n == 0)
            {
                i = m > n ? n : m;
            }
            else
            {
                i = m > n ? n / 2 : m / 2;
                int j;
                for (j = 2; j <= (m > n ? n/2 : m/2) && (n % i != 0 || m % i != 0); j++)
                {
                    if ((m > n ? n * 1.0f / j : m * 1.0f / j) % 1 != 0)
                    {
                        continue;
                    }
                    else
                    {
                        i = m > n ? n / j : m / j;
                    }
                }
                if (j> (m > n ? n / 2 : m / 2))
                {
                    i = 1;
                }
            }
            WriteLine($"您输入的两个数字{m}、{n}的最大公约数为：{i}");
            WriteLine($"您输入的两个数字{m}、{n}的最小公倍数为：{m * n / i}");
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

