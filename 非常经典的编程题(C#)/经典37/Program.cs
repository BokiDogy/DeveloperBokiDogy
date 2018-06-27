using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典37
{
    //    【程序37】   
    //题目：有n个人围成一圈，顺序排号。从第一个人开始报数（从1到3报数），凡报到3的人退出圈子，问最后留下的是原来第几号的那位。   
    //import java.util.Scanner;
    //    public class lianxi37
    //    {
    //        public static void main(String[] args)
    //        {
    //            Scanner s = new Scanner(System.in);
    //            System.out.print("请输入排成一圈的人数：");
    //            int n = s.nextInt();
    //            boolean[] arr = new boolean[n];
    //            for (int i = 0; i < arr.length; i++)
    //            {
    //                arr[i] = true;
    //            }
    //            int leftCount = n;
    //            int countNum = 0;
    //            int index = 0;
    //            while (leftCount > 1)
    //            {
    //                if (arr[index] == true)
    //                {
    //                    countNum++;
    //                    if (countNum == 3)
    //                    {
    //                        countNum = 0;
    //                        arr[index] = false;
    //                        leftCount--;
    //                    }
    //                }
    //                index++;
    //                if (index == n)
    //                {
    //                    index = 0;
    //                }
    //            }
    //            for (int i = 0; i < n; i++)
    //            {
    //                if (arr[i] == true)
    //                {
    //                    System.out.println("原排在第" + (i + 1) + "位的人留下了。");
    //                }
    //            }
    //        }
    //    }

    class Program
    {
        static void Main(string[] args)
        {
            const int n = 9;
            int m = ShuRu("游戏规则，淘汰数字m");
            string[] a = new string[n];
            Console.WriteLine($"请输入任意{a.Length}个参加者的名字:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"请输入{i + 1}号的名字:");
                a[i] = Console.ReadLine();
                if (i == a.Length - 1)
                {
                    Console.WriteLine("输入结束");
                }
            }
            Console.WriteLine("----------------------------------------------\n游戏开始：");
            int[] b = new int[a.Length * 2];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = i + 1;
            }
            int s = a.Length, x = 0, y = 1;
            while (b[b.Length - 1] == 0)
            {

                if (b[x] == 0)
                {
                    y--;
                }
                else if (y % m == 0)
                {
                    b[s] = b[x];
                    b[x] = 0;
                    s++;
                    for (int z = a.Length; z < s && s <= b.Length - 1; z++)
                    {
                        string start = z == a.Length ? $"第{s - a.Length}轮:" : "";
                        string end = z == s - 1 ? " 被淘汰\n" : ",";
                        Console.Write($"{start}{b[z]}号{a[b[z] - 1]}{end}");
                    }
                }
                x++;
                y++;
                if (x == a.Length)
                {
                    x = 0;
                }
            }
            Console.WriteLine($"幸存者是: {b[b.Length - 1]}号{a[b[b.Length - 1] - 1]} 。");
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

