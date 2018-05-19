using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典31
{
//    【程序31】
//题目：将一个数组逆序输出。   
//import java.util.*;
//    public class lianxi31
//    {
//        public static void main(String[] args)
//        {
//            Scanner s = new Scanner(System.in);
//            int a[] = new int[20];
//            System.out.println("请输入多个正整数（输入-1表示结束）：");
//            int i = 0, j;
//            do
//            {
//                a[i] = s.nextInt();
//                i++;
//            } while (a[i - 1] != -1);
//            System.out.println("你输入的数组为：");
//            for (j = 0; j < i - 1; j++)
//            {
//                System.out.print(a[j] + "   ");
//            }
//            System.out.println("\n数组逆序输出为：");
//            for (j = i - 2; j >= 0; j = j - 1)
//            {
//                System.out.print(a[j] + "   ");
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
            Console.WriteLine("\n逆序打印的结果为：");
            Console.Write("\na[]=[");
            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (i == 0)
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
