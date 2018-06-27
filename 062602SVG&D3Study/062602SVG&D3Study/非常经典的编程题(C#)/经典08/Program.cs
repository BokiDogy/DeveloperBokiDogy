using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 经典08
{
    //【程序8】   
    //题目：求s=a+aa+aaa+aaaa+aa...a的值，其中a是一个数字。例如2+22+222+2222+22222(此时共有5个数相加)，几个数相加有键盘控制。   
    //import java.util.*;
    //public class lianxi08 {
    //public static void main(String[] args) {
    //     long a , b = 0, sum = 0;
    //     Scanner s = new Scanner(System.in);
    //     System.out.print("输入数字a的值： ");
    //     a = s.nextInt();
    //     System.out.print("输入相加的项数：");
    //     int n = s.nextInt();
    //     int i = 0;
    //     while(i < n) {
    //      b = b + a;
    //      sum = sum + b;
    //      a = a * 10;
    //      ++ i;
    //     }
    //      System.out.println(sum);
    //}
    //} 
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0, num = 1;
            int a = ShuRu("a");
            int count = ShuRu("项数n");
            for (int i = 1; i <= count; i++)
            {

                for (int j = 1; j < i; j++)
                {
                    int b = num;
                    num *= 10;
                    num += b;
                }
                s += num;
                num = 1;
            }
            WriteLine($"s={a * s}");
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
