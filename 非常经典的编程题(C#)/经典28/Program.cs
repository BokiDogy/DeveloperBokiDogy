using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典28
{
//    【程序28】   
//题目：对10个数进行排序
//import java.util.*;
//public class lianxi28
//    {
//        public static void main(String[] args)
//        {
//            Scanner s = new Scanner(System.in);
//            int[] a = new int[10];
//            System.out.println("请输入10个整数：");
//            for (int i = 0; i < 10; i++)
//            {
//                a[i] = s.nextInt();
//            }
//            for (int i = 0; i < 10; i++)
//            {
//                for (int j = i + 1; j < 10; j++)
//                {
//                    if (a[i] > a[j])
//                    {
//                        int t = a[i];
//                        a[i] = a[j];
//                        a[j] = t;
//                    }
//                }
//            }
//            for (int i = 0; i < 10; i++)
//            {
//                System.out.print(a[i] + " ");
//            }
//        }
//    }

    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] a = new int[n];
            Console.WriteLine($"请输入任意{a.Length}个数字：");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"请输入第{i + 1}个数:");
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (i == a.Length - 1)
                {
                    Console.WriteLine("输入结束");
                }
            }
            Console.WriteLine("排序前的结果为：");
            Console.Write("\na[]=[");
            for (int i = 0; i < a.Length; i++)
            {
                if (i == a.Length - 1)
                {
                    Console.Write($"{a[i]}]");
                }
                else
                {
                    Console.Write($"{a[i]},");
                }
            }
            for (int j = 1; j < a.Length; j++)
            {
                int k = a[j];
                int i = j - 1;
                while (i >= 0 && a[i] > k)
                {
                    a[i + 1] = a[i];
                    i--;
                    a[i + 1] = k;
                }
            }
            Console.WriteLine("\n\n排序后的结果为：");
            Console.Write("\na[]=[");
            for (int i = 0; i < a.Length; i++)
            {
                if (i == a.Length - 1)
                {
                    Console.Write($"{a[i]}]");
                }
                else
                {
                    Console.Write($"{a[i]},");
                }
            }
            Console.ReadLine();
        }
    }
}
