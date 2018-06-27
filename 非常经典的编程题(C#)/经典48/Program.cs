using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典48
{
    //    【程序48】   
    //题目：某个公司采用公用电话传递数据，数据是四位的整数，在传递过程中是加密的，加密规则如下：每位数字都加上5,然后用和除以10的余数代替该数字，再将第一位和第四位交换，第二位和第三位交换。   
    //import java.util.*;
    //    public class lianxi48
    //    {
    //        public static void main(String args[])
    //        {
    //            Scanner s = new Scanner(System.in);
    //            int num = 0, temp;
    //            do
    //            {
    //                System.out.print("请输入一个4位正整数：");
    //                num = s.nextInt();
    //            } while (num < 1000 || num > 9999);
    //            int a[] = new int[4];
    //            a[0] = num / 1000; //取千位的数字 
    //            a[1] = (num / 100) % 10; //取百位的数字 
    //            a[2] = (num / 10) % 10; //取十位的数字 
    //            a[3] = num % 10; //取个位的数字 
    //            for (int j = 0; j < 4; j++)
    //            {
    //                a[j] += 5;
    //                a[j] %= 10;
    //            }
    //            for (int j = 0; j <= 1; j++)
    //            {
    //                temp = a[j];
    //                a[j] = a[3 - j];
    //                a[3 - j] = temp;
    //            }
    //            System.out.print("加密后的数字为：");
    //            for (int j = 0; j < 4; j++)
    //                System.out.print(a[j]);
    //        }
    //    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = ShuRu("一个四位数字n");
            while (n > 9999 || n < 1000)
            {
                Console.Write("您输入的数字无效，请再输入一次：");
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"您输入的原始数字为：{n}");
            int m = 1;
            for (int i = 0; i < 4; i++)
            {
                n = n / m % 10 < 5 ? (n + 5 * m) : (n - 5 * m);
                m *= 10;
            }
            n = n - n / 1000 * 999 + n % 10 * 999 + (n / 10 % 10) * 90 - (n / 100 % 10) * 90;
            Console.WriteLine("加密后的数字为：" + (n < 1000 ? "0" : "") + n);
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
