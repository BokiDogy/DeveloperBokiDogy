using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典16
{
//    【程序16】
//题目：输出9*9口诀。     
//public class lianxi16
//    {
//        public static void main(String[] args)
//        {
//            for (int i = 1; i < 10; i++)
//            {
//                for (int j = 1; j <= i; j++)
//                {
//                    System.out.print(j + "*" + i + "=" + j * i + "    ");
//                    if (j * i < 10) { System.out.print(" "); }
//                }
//                System.out.println();
//            }
//        }
//    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = ShuRu("乘法口诀的行数n");
            for (int i=1;i<=n;i++)
                {
                   for(int j=1;j<=i;j++)
                {
                    Console.Write($"{j}*{i}={i * j}\t");
                        if(j==i)
                    {
                        Console.Write("\n");
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
