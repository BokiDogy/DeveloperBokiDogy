using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典46
{
//    【程序46】   
//题目：两个字符串连接程序
//import java.util.*;
//public class lianxi46
//    {
//        public static void main(String[] args)
//        {
//            Scanner s = new Scanner(System.in);
//            System.out.print("请输入一个字符串：");
//            String str1 = s.nextLine();
//            System.out.print("请再输入一个字符串：");
//            String str2 = s.nextLine();
//            String str = str1 + str2;
//            System.out.println("连接后的字符串是：" + str);
//        }
//    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个字符串:");
            string a = Console.ReadLine();
            Console.WriteLine("请输入第二个字符串:");
            string b = Console.ReadLine();
            Console.WriteLine($"两个字符串连接后的结果为：\n{Join(a, b)}");
            Console.ReadLine();
        }
        public static string Join(string a,string b)
        {
            return a + b;
        }
    }
}
