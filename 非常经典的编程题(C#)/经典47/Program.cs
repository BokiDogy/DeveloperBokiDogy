using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典47
{
//    【程序47】   
//题目：读取7个数（1—50）的整数值，每读取一个值，程序打印出该值个数的＊。   
//import java.util.*;
//    public class lianxi47
//    {
//        public static void main(String[] args)
//        {
//            Scanner s = new Scanner(System.in);
//            int n = 1, num;
//            while (n <= 7)
//            {
//                do
//                {
//                    System.out.print("请输入一个1--50之间的整数：");
//                    num = s.nextInt();
//                } while (num < 1 || num > 50);
//                for (int i = 1; i <= num; i++)
//                {
//                    System.out.print("*");
//                }
//                System.out.println();
//                n++;
//            }
//        }
//    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[7];
            for(int i=0;i<a.Length;i++)
            {
                Console.Write($"请输入第{i + 1}个数字：");
                a[i] = Convert.ToInt32(Console.ReadLine());
                if(a[i] <= 0|| a[i] > 50)
                {
                    Console.WriteLine("您输入的数字无效，请再输入一次");
                    i--;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"输入{a[i]}个*结果为：");
                for(int j=0;j<a[i];j++)
                {
                    Console.Write("*");
                    if(j==a[i]-1)
                    {
                        Console.WriteLine("");
                    }
                }
            }
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
