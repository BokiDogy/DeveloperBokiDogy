using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典24
{
//    【程序24】   
//题目：给一个不多于5位的正整数，要求：一、求它是几位数，二、逆序打印出各位数字。   
////使用了长整型最多输入18位
//import java.util.*;
//    public class lianxi24
//    {
//        public static void main(String[] args)
//        {
//            Scanner s = new Scanner(System.in);
//            System.out.print("请输入一个正整数：");
//            long a = s.nextLong();
//            String ss = Long.toString(a);
//            char[] ch = ss.toCharArray();
//            int j = ch.length;
//            System.out.println(a + "是一个" + j + "位数。");
//            System.out.print("按逆序输出是：");
//            for (int i = j - 1; i >= 0; i--)
//            {
//                System.out.print(ch[i]);
//            }
//        }
//    }

    class Program
    {
        static void Main(string[] args)
        {
            long n;
            int m = 0;
            Console.Write("请输入一个正整数：");
            n = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"{n}各位数逆序打印的结果为：");
            int w = 1;
            while (n / w != 0)
            {
                Console.Write($"{n / w % 10} ");
                w *= 10;
                m++;
            }
            Console.WriteLine($"\n你输入的数字{n}是{m}位数。");
            Console.ReadLine();
        }
    }
}
