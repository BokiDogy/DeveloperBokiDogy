using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典08巩固
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
            int a = ShuRu("a");
            int n = ShuRu("n");
            long sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i == n)
                {
                    Console.Write($"{QiuDangQianXiang(a, i, a)}");
                }
                else
                {
                    Console.Write($"{QiuDangQianXiang(a, i, a)}+");
                }
                sum += QiuDangQianXiang(a, i, a);
            }
            Console.WriteLine($"={sum}");
            Console.ReadLine();
        }
        public static long QiuDangQianXiang(int a, int n, long res)//尾递归,res记录递归每一步返回值，减少内存占用
        {
            if (n == 1)
            {
                return res;
            }
            else if (n > 1)
            {
                return QiuDangQianXiang(a, n - 1, (res * 10 + a));
            }
            else
            {
                return 0;
            }
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
