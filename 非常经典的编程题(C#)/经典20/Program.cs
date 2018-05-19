using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典20
{
//    【程序20】   
//题目：有一分数序列：2/1，3/2，5/3，8/5，13/8，21/13...求出这个数列的前20项之和。 
//public class lianxi20
//    {
//        public static void main(String[] args)
//        {
//            int x = 2, y = 1, t;
//            double sum = 0;
//            for (int i = 1; i <= 20; i++)
//            {
//                sum = sum + (double)x / y;
//                t = y;
//                y = x;
//                x = y + t;
//            }
//            System.out.println("前20项相加之和是： " + sum);
//        }
//    }

    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, a = 1, b = 1;
            double result = 0;
            int n;
            Console.Write("请输入一个数字n=");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 3; i <= n + 2; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
                result += b / Convert.ToDouble(a);
            }
            Console.WriteLine($"前{n}项分数相加的和为：{result}");
            Console.ReadLine();
        }
    }
}
