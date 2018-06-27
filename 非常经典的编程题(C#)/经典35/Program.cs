using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典35
{
//    【程序35】   
//题目：输入数组，最大的与第一个元素交换，最小的与最后一个元素交换，输出数组。   
//import java.util.*;
//    public class lianxi35
//    {
//        public static void main(String[] args)
//        {
//            int N = 8;
//            int[] a = new int[N];
//            Scanner s = new Scanner(System.in);
//            int idx1 = 0, idx2 = 0;
//            System.out.println("请输入8个整数：");
//            for (int i = 0; i < N; i++)
//            {
//                a[i] = s.nextInt();
//            }
//            System.out.println("你输入的数组为：");
//            for (int i = 0; i < N; i++)
//            {
//                System.out.print(a[i] + " ");
//            }
//            int max = a[0], min = a[0];
//            for (int i = 0; i < N; i++)
//            {
//                if (a[i] > max)
//                {
//                    max = a[i];
//                    idx1 = i;
//                }
//                if (a[i] < min)
//                {
//                    min = a[i];
//                    idx2 = i;
//                }
//            }
//            if (idx1 != 0)
//            {
//                int temp = a[0];
//                a[0] = a[idx1];
//                a[idx1] = temp;
//            }
//            if (idx2 != N - 1)
//            {
//                int temp = a[N - 1];
//                a[N - 1] = a[idx2];
//                a[idx2] = temp;
//            }
//            System.out.println("\n交换后的数组为：");
//            for (int i = 0; i < N; i++)
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
            int max=a[0],x=0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]>max)
                {
                    max = a[i];
                    x = i;
                }
            }
            int min = a[0],y=0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                    y = i;
                }
            }
            int temp1 = a[x];
            a[x] = a[0];
            a[0] = temp1;
            int temp2 = a[y];
            a[y] = a[a.Length-1];
            a[a.Length - 1] = temp2;
            Console.WriteLine("交换后的结果为：");
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
