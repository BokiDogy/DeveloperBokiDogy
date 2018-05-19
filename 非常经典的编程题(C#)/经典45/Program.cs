using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典45
{
//    【程序45】   
//题目：判断一个素数能被几个9整除
////题目错了吧？能被9整除的就不是素数了！所以改成整数了。
//import java.util.*;
//public class lianxi45
//    {
//        public static void main(String[] args)
//        {
//            Scanner s = new Scanner(System.in);
//            System.out.print("请输入一个整数：");
//            int num = s.nextInt();
//            int tmp = num;
//            int count = 0;
//            for (int i = 0; tmp % 9 == 0;)
//            {
//                tmp = tmp / 9;
//                count++;
//            }
//            System.out.println(num + " 能够被 " + count + " 个9整除。");
//        }
//    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = ShuRu("一个任意正整数n");
            string result = n % 9 == 0 ? $"能被{n / 9}个9整除" : "不能被9整除";
            Console.WriteLine($"{n}{result}");
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
